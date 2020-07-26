using System.Collections.Generic;

namespace RiotAPI.Learning.Models {
    public class ParticipantTimeline {
        public int participantId { get; set; }
        public Dictionary<string, double> csDiffPerMinDeltas { get; set; }
        public Dictionary<string, double> damageTakenPerMinDeltas { get; set; }
        public string role { get; set; }
        public Dictionary<string, double> damageTakenDiffPerMinDeltas { get; set; }
        public Dictionary<string, double> xpPerMinDeltas { get; set; }
        public Dictionary<string, double> xpDiffPerMinDeltas { get; set; }
        public string lane { get; set; }
        public Dictionary<string, double> creepsPerMinDeltas { get; set; }
        public Dictionary<string, double> goldPerMinDeltas { get; set; }
    }
}