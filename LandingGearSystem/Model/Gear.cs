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
        public Thread Thread { get; set; }
        public Door Door { get; set; }

        public GearState GearState { get; set; } = GearState.LOCKUP;
        
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
                switch (GearState)
                {
                    case GearState.LOCKUP:
                        break;
                    default:
                        break;
                }
            }
        }

        public void Deploy()
        {
            GearState = GearState.LOCKDOWN;
        }
        public void Retract()
        {

        }
    }
}
