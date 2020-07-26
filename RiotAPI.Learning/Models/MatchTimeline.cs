using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotAPI.Learning.Models {
    public class MatchTimeline {
        public List<MatchFrame> frames { get; set; }
        public long frameInterval { get; set; }
    }
}
