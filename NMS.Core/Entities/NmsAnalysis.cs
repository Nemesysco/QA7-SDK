using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace NMS.Core.Entities
{
    public class NmsAnalysis
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<NmsAnalysisSummaryLine> SummaryLine { get; set; } = new List<NmsAnalysisSummaryLine>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<NmsAnalysisSegment> Segments { get; set; } = new List<NmsAnalysisSegment>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<NmsAnalysisCoreType> CoreType { get; set; } = new List<NmsAnalysisCoreType>();
    }

    public class NmsAnalysisCoreType
    {
        public int Channel { get; set; }
        public int ENLO { get; set; }
        public int ENEM { get; set; }
        public int STLO { get; set; }
        public int STEM { get; set; }

        public NmsAnalysisCoreType(
            int confidence, int concentration, int energy, int passion, int emotional, int uneasiness, int thinking, int stress, int channel)
        {
            Channel = channel;
            ENLO = (confidence + concentration + energy) / 3;
            ENEM = (energy + passion + emotional) / 3;
            STEM = (emotional + uneasiness + stress) / 3;
            STLO = (stress + thinking + confidence) / 3;
        }
    }

    public class NmsAnalysisSegment
    {
        public int SegmentId { get; set; }
        public double StartPos { get; set; }
        public double EndPos { get; set; }
        public int Channel { get; set; }
        public int Energy { get; set; }
        public int Happiness { get; set; }
        public int Sadness { get; set; }
        public int Anger { get; set; }
        public int Stress { get; set; }
        public int Uncertainty { get; set; }
        public int Excitement { get; set; }
        public int Concentration { get; set; }
        public int EmoCogRatio { get; set; }
        public int Hesitation { get; set; }
        public int BrainPower { get; set; }
        public int Embarrassment { get; set; }
        public int IntensiveThinking { get; set; }
        public int Imaginantion { get; set; }
        public int ExtremeEmotion { get; set; }
        public int Passion { get; set; }
        public int Atmosphere { get; set; }
        public int VoiceEnergy1 { get; set; }
        public int VoiceEnergy2 { get; set; }
        public int VoiceEnergy3 { get; set; }
        public int Anticipation { get; set; }
        public int Dissatisfaction { get; set; }
        public Color EnergyMap { get; set; } = Color.FromArgb(0, 0, 0);
        public Color StressMap { get; set; } = Color.FromArgb(0, 0, 0);
        public Color HASMap { get; set; } = Color.FromArgb(0, 0, 0);
        [JsonIgnore]
        public Guid FileId { get; set; }
    }

    public class NmsAnalysisSummaryLine
    {
        public string CleanCallTag(string callTag)
        {
            var callTagStr = callTag.Split('-', '(', ')');

            if (callTag.Contains('-'))
                return callTagStr[1].Trim();

            return callTagStr[0].Trim();
        }

        public int CallTag2int(string callTag)
        {
            return 1;
        }

        [JsonIgnore]
        public DateTime Date { get; set; } = DateTime.Now;

        [JsonIgnore]
        public string Filename { get; set; }
        public int Channel { get; set; }
        public string CallTag { get; set; }
        public int CallTagID { get; set; }
        public string Duration { get; set; }
        public int HighestQualityPriority { get; set; }
        public int FinalQualityPriority { get; set; }
        public int TonePriority { get; set; }
        public double Dissatisfaction { get; set; }
        public int VoiceEnergy { get; set; }
        public double AngerPerc { get; set; }
        public double StressPerc { get; set; }
        public double SadnessPerc { get; set; }
        public double HappinessPerc { get; set; }
        public double EmotionalEnergy { get; set; }
        public int Energy { get; set; }
        public int Passion { get; set; }
        public int Emotional { get; set; }
        public int Uneasiness { get; set; }
        public int Stress { get; set; }
        public int Thinking { get; set; }
        public int Confidence { get; set; }
        public int Concentration { get; set; }
        public int Anticipation { get; set; }
        public int CSCScore { get; set; }
        public int Final10 { get; set; }
        [JsonIgnore]
        public Guid FileID { get; set; } = Guid.NewGuid();
    }

}
