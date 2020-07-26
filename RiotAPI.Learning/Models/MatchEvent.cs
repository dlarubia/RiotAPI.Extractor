using System.Collections.Generic;

namespace RiotAPI.Learning.Models {
    public class MatchEvent {
        public string laneType { get; set; }
        public int skillSlot { get; set; }
        public string ascendedType { get; set; }
        public int creatorId { get; set; }
        public int afterId { get; set; }
        public string eventType { get; set; }
        public string type { get; set; }
        public string levelUpType { get; set; }
        public string wardType { get; set; }
        public int participantId { get; set; }
        public string towerType { get; set; }
        public int itemId { get; set; }
        public int beforeId { get; set; }
        public string pointCaptured { get; set; }
        public string monsterType { get; set; }
        public string monsterSubType { get; set; }
        public int teamId { get; set; }
        public MatchPosition position { get; set; }
        public int killerId { get; set; }
        public long timestamp { get; set; }
        public List<int> assistingParticipantIds { get; set; }
        public string buildingType { get; set; }
        public int victimId { get; set; }
    }
}