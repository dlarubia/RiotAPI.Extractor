using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class RoundResult {
        public int roundNum { get; set; }
        public string roundResult { get; set; }
        public string roundCeremony { get; set; }
        public string winningTeam { get; set; }
        public string bombPlanter { get; set; } // PUUID of player
        public string bombDefuser { get; set; } // PUUID of player
        public int plantRoundTime { get; set; }
        public List<PlayerLocations> plantPlayerLocations { get; set; }
        public Location plantLocation { get; set; }
        public string plantSite { get; set; }
        public int defuseRoundTime { get; set; }
        public List<PlayerLocations> defusePlayerLocations { get; set; }
        public Location defuseLocation { get; set; }
        public List<PlayerStats> playerStats { get; set; }
        public string roundResultCode { get; set; }
    }
}
