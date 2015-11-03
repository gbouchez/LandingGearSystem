using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class LandingSet
    {
        public LandingSetPosition Position { get; set; }
        public Door Door { get; set; }
        public LandingGear LandingGear { get; set; }
    }
}
