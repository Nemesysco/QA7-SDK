using System.IO;

namespace NMS.Core.Utility.Converters
{
    public static class AudioConverter
    {
        public static string ToWav(string srcFile, string ffmpegPath, string dataPath, bool toMono = false)
        {
            var bareFileName = Path.GetFileNameWithoutExtension(srcFile);
            string dstFile = Path.Combine(dataPath, bareFileName) + $"_8Khz.wav";

            string codec_pcm = "-codec:a pcm_s16le";
            string samplerate = "-ar 8000";
            string monoArgs = toMono ? "-ac 1" : "";

            string ffmpegArg = $"-i \"{srcFile}\" {monoArgs} {codec_pcm} {samplerate} \"{dstFile}\" -loglevel quiet -y";
            NmsLogger.Info($"Convert to WAV. FFMpeg path: {ffmpegPath}; args: {ffmpegArg}");

            using (new FFmpegProcess(ffmpegPath, ffmpegArg))
            {
                return dstFile;
            }
        }
    }
}
