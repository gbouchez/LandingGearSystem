using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class Plane
    {
        private static Plane instance;
        public static Plane Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new Plane();
                }
                return instance;
            }
        }
        public List<LandingSet> LandingSets { get; set; } = new List<LandingSet>();
        public LandingSet FrontSet;
        public LandingSet LeftSet;
        public LandingSet RightSet;

        public Plane()
        {
            LandingSet FrontSet = new LandingSet(LandingSetPosition.FRONT);
            LandingSet LeftSet  = new LandingSet(LandingSetPosition.LEFT);
            LandingSet RightSet = new LandingSet(LandingSetPosition.RIGHT);
        }
    }
}
