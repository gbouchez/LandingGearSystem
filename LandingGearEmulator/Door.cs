using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class Door : HydraulicManagedInterface
    {
        private HydraulicCylinder cylinder;
        public HydraulicCylinder Cylinder { get; set; }

        public LandingSet LandingSet { get; set; }
    }
}
