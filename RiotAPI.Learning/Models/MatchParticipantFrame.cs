namespace RiotAPI.Learning.Models {
    public class MatchParticipantFrame {
        public int participantId { get; set; }
        public int minionsKilled { get; set; }
        public int teamScore { get; set; }
        public int dominionScore { get; set; }
        public int totalGold { get; set; }
        public int level { get; set; }
        public int xp { get; set; }
        public int currentGold { get; set; }
        public MatchPosition position { get; set; }
        public int jungleMinionsKilled { get; set; }
    }
}