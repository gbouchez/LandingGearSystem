using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandingGearSystem;

namespace LandingGearPilotInterface.Interface
{
    class CockpitHandle
    {
        private HandleState state;
        public HandleState State {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (HandleState.DOWN == state)
                {
                    MainSystem.Instance.InitiateLandingSequence();
                }
                else if (HandleState.UP == state)
                {
                    MainSystem.Instance.InitiateRetractionSequence();
                }
            }
        }
    }
}
