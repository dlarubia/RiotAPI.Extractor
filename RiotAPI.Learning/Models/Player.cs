using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class Player {
        public string puuid { get; set; }
        public string teamId { get; set; }
        public string partyId { get; set; }
        public string characterId { get; set; }
        public PlayerStats stats { get; set; }
        public int competitiveTier { get; set; }
        public string playerCard { get; set; }
        public string playerTitle { get; set; }
    }
}
