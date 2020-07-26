using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class Matchlist {
        public int startIndex { get; set; }
        public int totalGames { get; set; }
        public int endIndex { get; set; }
        public List<MatchReference> matches { get; set; }
    }
}
