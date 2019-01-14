using System;
using System.Collections.Generic;

namespace StarShips
{
    public class SWPage
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<StarShip> results { get; set; }
    }
}
