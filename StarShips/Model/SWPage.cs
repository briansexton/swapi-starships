using System;
using System.Collections.Generic;

namespace StarShips
{
    public class SWPage
    {
        public string Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<StarShip> Results { get; set; }
    }
}
