using NAudio.Wave;
using SharpAvi.Codecs;
using SharpAvi.Output;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace quick_screen_recorder
{
    class Recorder : IDisposable
    {
        private AviWriter writer;
        private IAviVideoStream videoStream;
        private IAviAudioStream audioStream;

        private IWaveIn audioSource;
        //private IWaveIn wasapiSource;

        private Thread screenThread;

        private ManualResetEvent stopThread = new ManualResetEvent(false);
        private AutoResetEvent videoFrameWritten = new AutoResetEvent(false);
        private AutoResetEvent audioBlockWritten = new AutoResetEvent(false);

        //private WaveFileWriter waveFile;

        private int x;
        private int y;
        private int width;
        private int height;
        private bool captureCursor;

        [StructLayout(LayoutKind.Sequential)]
        private struct POINTAPI
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll")]
        static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

        const Int32 CURSOR_SHOWING = 0x00000001;

        public Recorder(string filePath, 
            int quality, int x, int y, int width, int height, bool captureCursor, 
            int inputSourceIndex)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.captureCursor = captureCursor;

            writer = new AviWriter(filePath)
            {
                FramesPerSecond = 15,
                EmitIndex1 = true,
            };

            videoStream = writer.AddMotionJpegVideoStream(width, height, quality);
            videoStream.Name = "Quick Screen Recorder - Video stream";

            if (inputSourceIndex >= 0)
            {
                var waveFormat = new WaveFormat(44100, 16, 1);

                audioStream = writer.AddAudioStream(
                    channelCount: waveFormat.Channels,
                    samplesPerSecond: waveFormat.SampleRate,
                    bitsPerSample: waveFormat.BitsPerSample
                );
                audioStream.Name = "Quick Screen Recorder - Input audio stream";

                audioSource = new WaveInEvent()
                {
                    DeviceNumber = inputSourceIndex,
                    WaveFormat = waveFormat,
                    BufferMilliseconds = (int)Math.Ceiling(1000 / writer.FramesPerSecond),
                    NumberOfBuffers = 3,
                };
                audioSource.DataAvailable += audioSource_DataAvailable;

                //waveFile = new WaveFileWriter(filePath + ".wav", audioSource.WaveFormat);
            } 
            else if (inputSourceIndex == -1)
            {
                //var waveFormat = new WaveFormat(44100, 16, 1);
                audioSource = new WasapiLoopbackCapture();

                audioStream = writer.AddAudioStream(
                    channelCount: audioSource.WaveFormat.Channels,
                    samplesPerSecond: audioSource.WaveFormat.SampleRate,
                    bitsPerSample: audioSource.WaveFormat.BitsPerSample
                );
                audioStream.Name = "Quick Screen Recorder - System sounds audio stream";


                audioSource.DataAvailable += audioSource_DataAvailable;

                //waveFile = new WaveFileWriter(filePath + ".wav", wasapiSource.WaveFormat);
            }

            screenThread = new Thread(RecordScreen)
            {
                Name = typeof(Recorder).Name + ".RecordScreen",
                IsBackground = true
            };

            if (audioSource != null)
            {
                videoFrameWritten.Set();
                audioBlockWritten.Reset();
                audioSource.StartRecording();
            }

            //if (wasapiSource != null)
            //{
            //    videoFrameWritten.Set();
            //    audioBlockWritten.Reset();
            //    wasapiSource.StartRecording();
            //}

            screenThread.Start();
        }

        public void Dispose()
        {
            stopThread.Set();
            screenThread.Join();

            if (audioSource != null)
            {
                audioSource.StopRecording();
                audioSource.DataAvailable -= audioSource_DataAvailable;
            }

            //if (waveFile != null)
            //{
            //    waveFile.Dispose();
            //    waveFile = null;
            //}

            writer.Close();

            stopThread.Dispose();
        }

        private void RecordScreen()
        {
            var stopwatch = new Stopwatch();
            var buffer = new byte[width * height * 4];

            Task videoWriteTask = null;

            var isFirstFrame = true;
            var shotsTaken = 0;
            var timeTillNextFrame = TimeSpan.Zero;
            stopwatch.Start();

            while (!stopThread.WaitOne(timeTillNextFrame))
            {
                Screenshot(buffer);
                shotsTaken++;

                if (!isFirstFrame)
                {
                    videoWriteTask.Wait();

                    videoFrameWritten.Set();
                }

                if (audioStream != null)
                {
                    var signalled = WaitHandle.WaitAny(new WaitHandle[] { audioBlockWritten, stopThread });
                    if (signalled == 1)
                        break;
                }

                videoWriteTask = videoStream.WriteFrameAsync(true, buffer, 0, buffer.Length);

                timeTillNextFrame = TimeSpan.FromSeconds(shotsTaken / (double)writer.FramesPerSecond - stopwatch.Elapsed.TotalSeconds);
                if (timeTillNextFrame < TimeSpan.Zero)
                {
                    timeTillNextFrame = TimeSpan.Zero;
                }

                isFirstFrame = false;
            }

            stopwatch.Stop();

            if (!isFirstFrame)
            {
                videoWriteTask.Wait();
            }
        }

        private void Screenshot(byte[] Buffer)
        {
            using (var BMP = new Bitmap(width, height))
            {
                using (var g = Graphics.FromImage(BMP))
                {
                    g.CopyFromScreen(new Point(x, y), Point.Empty, new Size(width, height), CopyPixelOperation.SourceCopy);

                    if (captureCursor)
                    {
                        CURSORINFO pci;
                        pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));

                        if (GetCursorInfo(out pci))
                        {
                            if (pci.flags == CURSOR_SHOWING)
                            {
                                DrawIcon(g.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
                                g.ReleaseHdc();
                            }
                        }
                    }

                    g.Flush();

                    var bits = BMP.LockBits(
                        new Rectangle(0, 0, width, height),
                        ImageLockMode.ReadOnly,
                        PixelFormat.Format32bppRgb
                    );
                    Marshal.Copy(bits.Scan0, Buffer, 0, Buffer.Length);
                    BMP.UnlockBits(bits);
                }
            }
        }

        private void audioSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            //if (waveFile != null)
            //{
            //    waveFile.Write(e.Buffer, 0, e.BytesRecorded);
            //    waveFile.Flush();
            //}

            var signalled = WaitHandle.WaitAny(new WaitHandle[] { videoFrameWritten, stopThread });
            if (signalled == 0)
            {
                audioStream.WriteBlock(e.Buffer, 0, e.BytesRecorded);
                audioBlockWritten.Set();
            }
        }
    }
}
