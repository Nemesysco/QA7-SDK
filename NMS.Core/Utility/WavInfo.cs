using NAudio.Wave;
using System;

namespace NMS.Core.Utility
{
    public class WavInfo
    {
        public int NoOfChannels { get; private set; }
        public TimeSpan TotalTime { get; private set; }
        public int SampleRate { get; private set; }
        public int BitsPerSample { get; private set; }
        public int BytesPerSecond { get; private set; }
        public string Encoding { get; private set; }
        public int BlockAlign { get; private set; }
        public int Length { get; private set; }


        public static WavInfo Get(string fileName)
        {
            return new WavInfo(fileName);
        }

        public WavInfo()
        {
        }

        private WavInfo(string fileName)
        {
            using (var wr = new WaveFileReader(fileName))
            {
                NoOfChannels = wr.WaveFormat.Channels;
                TotalTime = wr.TotalTime;
                SampleRate = wr.WaveFormat.SampleRate;
                BitsPerSample = wr.WaveFormat.BitsPerSample;
                BytesPerSecond = wr.WaveFormat.AverageBytesPerSecond;
                Encoding = wr.WaveFormat.Encoding.ToString();
                BlockAlign = wr.WaveFormat.BlockAlign;
                Length = (int)wr.Length;
            }
        }
    }
}
