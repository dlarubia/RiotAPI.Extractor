using System.Collections.Generic;

namespace RiotAPI.Learning.Models {
    public class MatchFrame {
        public Dictionary<string, MatchParticipantFrame> participantFrames { get; set; }
        public List<MatchEvent> events { get; set; }
        public long timestamp { get; set; }
    }
}