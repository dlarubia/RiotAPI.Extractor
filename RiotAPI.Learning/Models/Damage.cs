using System.Runtime.Intrinsics.X86;

namespace RiotAPI.Learning.Models {
    public class Damage {
        public string receiver { get; set; } // PUUID
        public int damage { get; set; }
        public int legshots { get; set; }
        public int bodyshots { get; set; }
        public int headshots { get; set; }
    }
}