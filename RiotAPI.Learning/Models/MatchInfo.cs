using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class MatchInfo {
        public string matchId { get; set; }
        public string mapId { get; set; }
        public int gameLehgthMillis { get; set; }
        public long gameStartMillis { get; set; }
        public string provisioningFlowId { get; set; }
        public bool isCompleted { get; set; } // Boolean?
        public string customGameName { get; set; }
        public string queueId { get; set; }
        public string gameMode { get; set; }
        public bool isRanked { get; set; } // Boolean?
        public string seasonId { get; set; }

    }
}
