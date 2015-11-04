using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem.Interface
{
    class LightManager
    {
        // Green :  Gears are locked down
        // Orange : Gears maneuvering
        // Red :    Landing gears system failure
        public List<Light> Lights = new List<Light>();
    }
}
