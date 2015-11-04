using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class GeneralElectroValve : ElectroValve
    {
        public List<HydraulicCylinder> Cylinders { get; set; }
    }
}
