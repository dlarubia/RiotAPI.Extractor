using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class Match {
        public List<MatchInfo> matchInfo { get; set; }
        public List<Player> players { get; set; }
        public List<Team> teams { get; set; }
        public List<RoundResult> roundResults { get; set; }
    }
}
