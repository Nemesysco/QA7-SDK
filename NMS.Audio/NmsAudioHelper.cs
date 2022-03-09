using System;
using System.IO;

using NAudio.Wave;

namespace NMS.Audio
{
    public class NmsAudioHelper
    {
        public static string SaveFile(string srcFileName, string dstFolder)
        {
            float max = 0;

            using (var reader = new AudioFileReader(srcFileName))
            {
                float[] buffer = new float[reader.WaveFormat.SampleRate];
                int read;
                do
                {
                    read = reader.Read(buffer, 0, buffer.Length);
                    for (int n = 0; n < read; n++)
                    {
                        var abs = Math.Abs(buffer[n]);
                        if (abs > max) max = abs;
                    }
                } while (read > 0);


                if (max == 0 || max > 1.0f)
                    return srcFileName;

                reader.Position = 0;
                reader.Volume = 1.0f / max;

                if (reader.Volume > 16)
                    return srcFileName;

                var fname = Path.GetFileNameWithoutExtension(srcFileName);
                var dstFileName = Path.Combine(dstFolder, fname + "_amp.wav");
                WaveFileWriter.CreateWaveFile16(dstFileName, reader);
                return dstFileName;
            }
        }
    }
}
