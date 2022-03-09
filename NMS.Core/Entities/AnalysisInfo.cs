namespace NMS.Core.Entities
{
    public class AnalysisInfo
    {
        public string AudioFile { get; set; }
        public string Segments { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string Message { get; set; } = string.Empty;


        public AnalysisInfo(string audioFile)
        {
            AudioFile = audioFile;
        }
    }
}
