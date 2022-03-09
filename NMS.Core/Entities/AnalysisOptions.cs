namespace NMS.Core.Entities
{
    public class AnalysisOptions
    {
        public bool SetMono { get; set; } = false;
        public byte AnalysisType { get; set; } = 1;
        public short Bglevel { get; set; } = 1000;
        public bool Normalize { get; set; } = false;
        public byte SegMaxLength { get; set; } = 2;
        public byte Ka { get; set; } = 0;
    }
}
