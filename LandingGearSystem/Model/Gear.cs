using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LandingGearSystem.Model
{
    class Gear
    {
        public int Position { get; set; }
        public Thread Thread { get; set; }
        public Door Door { get; set; }

        private GearState state = GearState.LOCKUP;
        public GearState GearState {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public GearState FinalState { get; set; } = GearState.LOCKUP;

        public int Deployment { get; set; } = 0;
        const int FullDeployment = 1000;

        public void Init()
        {
            Thread = new Thread(this.Live);
            Thread.IsBackground = true;
            Thread.Start();
        }

        public void Live()
        {
            while (true)
            {
                if (Deployment == 0 && GearState != GearState.LOCKUP)
                {
                    GearState = GearState.LOCKUP;
                    Console.WriteLine("Lockup");
                }
                else if (Deployment == FullDeployment && GearState != GearState.LOCKDOWN)
                {
                    GearState = GearState.LOCKDOWN;
                    Console.WriteLine("Lockdown");
                }

                switch (FinalState)
                {
                    case GearState.LOCKUP:
                        if (GearState == FinalState)
                        {
                            break;
                        }
                        Deployment--;
                        break;
                    case GearState.LOCKDOWN:
                        if (GearState == FinalState)
                        {
                            break;
                        }
                        Deployment++;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Deploy()
        {
            FinalState = GearState.LOCKDOWN;
        }

        public void Retract()
        {
            FinalState = GearState.LOCKUP;
        }
    }
}
