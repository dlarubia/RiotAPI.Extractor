namespace RiotAPI.Learning.Models {
    public class Player {
        public int profileIcon { get; set; }
        public string accountId { get; set; } // Player's original accountId
        public string matchHistoryUri { get; set; }
        public string currentAccountId { get; set; } // Player's current accountId when the match was played
        public string currentPlatformId { get; set; } // Player's current platformId when the match was played
        public string summonerName { get; set; }
        public string summonerId { get; set; } // Player's summonerId (Encrypted)
        public string platformId { get; set; } // Player's original platformId
    }
}