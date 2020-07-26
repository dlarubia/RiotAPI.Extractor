using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class PlayerStats {
        public string puuid { get; set; }
        public List<Kill> kills { get; set; }
        public List<Damage> damage { get; set; }
        public int score { get; set; }
        public Economy economy { get; set; }
        public Ability ability { get; set; }
    }
}
