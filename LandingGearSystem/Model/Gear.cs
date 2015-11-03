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

        public GearState GearState { get; set; }
        
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
            }
        }

        public void Deploy()
        {

        }
        public void Retract()
        {

        }
    }
}
