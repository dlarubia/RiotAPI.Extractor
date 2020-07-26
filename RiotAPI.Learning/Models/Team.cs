using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class Team {
        public string teamId { get; set; }
        public bool won { get; set; }
        public int roundsPlayed { get; set; }
        public int roundsWon { get; set; }
    }
}
