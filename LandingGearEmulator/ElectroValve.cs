using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class ElectroValve : ElectroStimulatedInterface
    {
        public ElectroValve Valve { get; set; } = null;
        public List<ElectroStimulatedInterface> RelatedSystems { get; set; } = new List<ElectroStimulatedInterface>();

        public void OnElectroStimulation()
        {
            foreach (ElectroStimulatedInterface system in RelatedSystems)
            {
                system.OnElectroStimulation();
            }
        }
    }
}
