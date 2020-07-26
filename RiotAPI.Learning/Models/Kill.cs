using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class Kill {
        public int gameTime { get; set; }
        public int roundTime { get; set; }  // PUUID
        public string killer { get; set; } // PUUID
        public string victim { get; set; }
        public Location victimLocation { get; set; }
        public List<string> assistants { get; set; } // List of PUUIDs
        public List<PlayerLocations> playerLocations { get; set; }
        public FinishingDamage finishingDamage { get; set; }
    }
}
