using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using NMS.Core.Entities;
using NMS.Core.Entities.Enums;
using NMS.Core.Utility;

using QA70_com_2018;

namespace NMS.Core
{
    public class AnalysisManager : IDisposable
    {
        private string _token;
        private mngQA7_FileProcessorCls _processor;


        public AnalysisManager()
        {
            _processor = new mngQA7_FileProcessorCls();

            var pid = _processor.getProcessId();
            _token = LicenseManager.GetAnalysisToken(pid);
        }

        ~AnalysisManager()
        {
            Dispose(false);
        }


        public AnalysisInfo ProcessFile(string audioFile, AnalysisOptions options)
        {
            var analysis = new AnalysisInfo(audioFile);

            if (_token.ToLower().Contains("error"))
            {
                analysis.Message = _token;
                return analysis;
            }

            var rc = _processor.Activate(_token, true, 1, false);
            if (rc != 0)
            {
                NmsLogger.Error($"ProcessFile rc = {rc} | analysis token = {_token}");
                analysis.Message = _token;
                return analysis;
            }

            _processor.ConfigTestData(8000, options.Bglevel, options.SegMaxLength, options.AnalysisType);

            var pSummaryLine = string.Empty;
            var pQA7Reports = string.Empty;
            var csvLog = string.Empty;
            var errMsg = string.Empty;

            try
            {
                rc = _processor.ProcessFile(audioFile, ref csvLog, ref errMsg, ref pSummaryLine, ref pQA7Reports);
            }
            catch (Exception ex)
            {
                NmsLogger.Error($"{ServiceType.QA7} ERR: {ex.ToString()}");

                analysis.Message = errMsg;
                return analysis;
            }


            if (errMsg != string.Empty) // ERROR
            {
                NmsLogger.Error($"{ServiceType.QA7} ERR: {errMsg}");

                analysis.Message = errMsg;
                return analysis;
            }

            // SUCCESS
            csvLog = csvLog.Replace("Seg#;StartPos(Sec.);EndPos(Sec.);CNL;Energy;Content;upset;Angry;Stressed;Uncertain;Excited;Concentrated;EmoCogRatio;Hesitation;BrainPower;Embar.;I.Think;Imagin;ExtremeEmotion;SAF;Atmos.;VoiceEnergy1;VoiceEnergy2;VoiceEnergy3;Anticipation;Dissatisfaction",
                                                    "Seg#;StartPos;EndPos;CNL;Energy;Content;Upset;Angry;Stressed;Uncertain;Excited;Concentrated;EmoCogRatio;Hesitation;BrainPower;Embar;IThink;Imagin;ExtremeEmotion;SAF;Atmos;VoiceEnergy1;VoiceEnergy2;VoiceEnergy3;Anticipation;Dissatisfaction");

            analysis.Segments = csvLog;
            analysis.Summary = pSummaryLine;
            analysis.Details = pQA7Reports;

            return analysis;
        }

        public List<NmsAnalysisSegment> GetSegments(AnalysisInfo analysis, NmsAnalysis segmentResult, Guid? fileId = null)
        {
            if (analysis.Segments is null)
                return new List<NmsAnalysisSegment>();

            var segList = analysis.Segments.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            double rotatingEnergy = 0;
            double rotatingStress = 0;

            double rotatingHappy = 0;
            double rotatingAngry = 0;
            double rotatingSad = 0;

            foreach (var row in segList.Skip(1))
            {
                string[] arr = row.Split(';');

                var segmentObj = new NmsAnalysisSegment
                {
                    SegmentId = NumberUtility.ToInt(arr[0]),
                    StartPos = NumberUtility.ToDouble(arr[1]),
                    EndPos = NumberUtility.ToDouble(arr[2]),
                    Channel = NumberUtility.ToInt(arr[3]),
                    Energy = NumberUtility.ToInt(arr[4]),
                    Happiness = NumberUtility.ToInt(arr[5]),
                    Sadness = NumberUtility.ToInt(arr[6]),
                    Anger = NumberUtility.ToInt(arr[7]),
                    Stress = NumberUtility.ToInt(arr[8]),
                    Uncertainty = NumberUtility.ToInt(arr[9]),
                    Excitement = NumberUtility.ToInt(arr[10]),
                    Concentration = NumberUtility.ToInt(arr[11]),
                    EmoCogRatio = NumberUtility.ToInt(arr[12]),
                    Hesitation = NumberUtility.ToInt(arr[13]),
                    BrainPower = NumberUtility.ToInt(arr[14]),
                    Embarrassment = NumberUtility.ToInt(arr[15]),
                    IntensiveThinking = NumberUtility.ToInt(arr[16]),
                    Imaginantion = NumberUtility.ToInt(arr[17]),
                    ExtremeEmotion = NumberUtility.ToInt(arr[18]),
                    Passion = NumberUtility.ToInt(arr[19]),
                    Atmosphere = NumberUtility.ToInt(arr[20]),
                    VoiceEnergy1 = NumberUtility.ToInt(arr[21]),
                    VoiceEnergy2 = NumberUtility.ToInt(arr[22]),
                    VoiceEnergy3 = NumberUtility.ToInt(arr[23]),
                    Anticipation = NumberUtility.ToInt(arr[24]),
                    Dissatisfaction = NumberUtility.ToInt(arr[25]),
                    FileId = fileId ?? Guid.NewGuid(),
                };

                //Energy
                rotatingEnergy = ((rotatingEnergy * 3) + segmentObj.Energy) / 4;
                var nColEnergy = (int)rotatingEnergy * 6;
                nColEnergy = nColEnergy > 255 ? 255 : nColEnergy;
                segmentObj.EnergyMap = Color.FromArgb(nColEnergy, nColEnergy, nColEnergy);

                //Stress
                rotatingStress = ((rotatingStress * 3) + (segmentObj.Stress * 10)) / 4;
                int nColStress = (int)rotatingStress;
                nColStress = nColStress > 255 ? 255 : nColStress < 0 ? 0 : nColStress;
                segmentObj.StressMap = Color.FromArgb(nColStress, nColStress, 0);

                //Happy Angry Sad (HAS)
                rotatingHappy = ((rotatingHappy * 2) + segmentObj.Happiness) / 3;
                var nGreen = (int)rotatingHappy * 30;

                rotatingSad = ((rotatingSad * 2) + segmentObj.Sadness) / 3;
                var nBlue = (int)rotatingSad * 30;

                rotatingAngry = ((rotatingAngry * 2) + segmentObj.Anger) / 3;
                var nRed = (int)rotatingAngry * 30;

                nGreen = nGreen > 255 ? 255 : nGreen;
                nRed = nRed > 255 ? 255 : nRed;
                nBlue = nBlue > 255 ? 255 : nBlue;

                segmentObj.HASMap = Color.FromArgb(nRed, nGreen, nBlue);

                segmentResult.Segments.Add(segmentObj);
            }

            return segmentResult.Segments;
        }

        public List<NmsAnalysisSummaryLine> GetSummaryLines(AnalysisInfo analysis, NmsAnalysis segmentResult, Guid? fileId = null)
        {
            if (analysis.Summary is null)
            {
                return new List<NmsAnalysisSummaryLine>();
            }

            var summaryLineList = analysis.Summary.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int channelCounter = 0;

            if (summaryLineList[0].Contains("Too Short"))
            {
                segmentResult.SummaryLine.Add(
                    new NmsAnalysisSummaryLine
                    {
                        Filename = analysis.AudioFile,
                        CallTag = "Too Short",
                        FileID = fileId ?? Guid.NewGuid()
                    });
            }
            else
            {

                segmentResult.SummaryLine.AddRange(
                    from row in summaryLineList
                    where !row.Contains("Too Short")
                    let arr = row.Split(';').ToArray()
                    select new NmsAnalysisSummaryLine
                    {
                        Filename = analysis.AudioFile,
                        Channel = channelCounter++,
                        CallTag = arr[0],
                        CallTagID = CallTag2Int(arr[0]),
                        Duration = arr[1],
                        HighestQualityPriority = NumberUtility.ToInt(arr[2]),
                        FinalQualityPriority = NumberUtility.ToInt(arr[3]),
                        TonePriority = NumberUtility.ToInt(arr[4]),
                        Dissatisfaction = NumberUtility.ToDouble(arr[5]),
                        VoiceEnergy = NumberUtility.ToInt(arr[6]),
                        AngerPerc = NumberUtility.ToDouble(arr[7]),
                        StressPerc = NumberUtility.ToDouble(arr[16]) / 20,
                        SadnessPerc = NumberUtility.ToDouble(arr[9]),
                        HappinessPerc = NumberUtility.ToDouble(arr[10]),
                        EmotionalEnergy = NumberUtility.ToDouble(arr[11]),
                        Energy = NumberUtility.ToInt(arr[12]),
                        Passion = NumberUtility.ToInt(arr[13]),
                        Emotional = NumberUtility.ToInt(arr[14]),
                        Uneasiness = NumberUtility.ToInt(arr[15]),
                        Stress = NumberUtility.ToInt(arr[16]),
                        Thinking = NumberUtility.ToInt(arr[17]),
                        FileID = fileId ?? Guid.NewGuid(),
                        Confidence = NumberUtility.ToInt(arr[18]),
                        Concentration = NumberUtility.ToInt(arr[19]),
                        Anticipation = NumberUtility.ToInt(arr[20]),
                        CSCScore = NumberUtility.ToInt(arr[21]),
                        Final10 = NumberUtility.ToInt(arr[22])
                    });
            }


            return segmentResult.SummaryLine;
        }

        public List<NmsAnalysisCoreType> GetCoreTypes(NmsAnalysis segmentResult)
        {
            var lines = segmentResult.SummaryLine
                .Select(a => new { a.Confidence, a.Concentration, a.Energy, a.Emotional, a.Passion, a.Uneasiness, a.Thinking, a.Stress, a.Channel })
                .ToList();

            foreach (var line in lines)
            {
                segmentResult.CoreType.Add(new NmsAnalysisCoreType(
                    line.Confidence,
                    line.Concentration,
                    line.Energy,
                    line.Emotional,
                    line.Passion,
                    line.Uneasiness,
                    line.Thinking,
                    line.Stress,
                    line.Channel));
            }

            return segmentResult.CoreType;
        }


        private int CallTag2Int(string tag)
        {
            switch (tag)
            {
                case "Too Short": return 0;
                case "Normal Call": return 1;
                case "Stress Call": return 2;
                case "Energy Irregularity": return 3;
                case "Dissatisfaction": return 4;
                case "Aggressive Call": return 5;
                case "Tone Priority": return 6;
                case "Mid Priority": return 7;
                case "High Tone Priority": return 8;
                case "High Priority": return 9;

                default: return -1;
            }
        }

        #region IDisposable Support

        private bool _disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _processor.Dispose();
                    _processor = null;
                }

                _disposed = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above. (DEV)
            Dispose(true);
            // Uncomment the following line if the finalizer is overridden above. (DEV)
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
