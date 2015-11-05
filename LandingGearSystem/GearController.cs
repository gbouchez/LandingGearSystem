using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LandingGearSystem.Model;

namespace LandingGearSystem
{
    class GearController
    {
        private static GearController instance;
        private Gear frontGear;
        private Gear rightGear;
        private Gear leftGear;

        public volatile bool ShouldDeploy;
        public volatile bool ShouldRetract;

        public static GearController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GearController();
                }
                return instance;
            }
        }

        internal void ComputeLightStates()
        {
            Console.WriteLine("test ?");
        }

        public GearController()
        {
            frontGear = new Gear(this);
            rightGear = new Gear(this);
            leftGear = new Gear(this);
        }

        public void Deploy()
        {
            ShouldDeploy = true;
            ShouldRetract = false;
            Thread thread = new Thread(frontGear.Deploy);
            thread.IsBackground = true;
            thread.Start();
            thread = new Thread(rightGear.Deploy);
            thread.IsBackground = true;
            thread.Start();
            thread = new Thread(leftGear.Deploy);
            thread.IsBackground = true;
            thread.Start();
        }

        public void Retract()
        {
            ShouldRetract = true;
            ShouldDeploy = false;
            Thread thread = new Thread(frontGear.Retract);
            thread.IsBackground = true;
            thread.Start();
            thread = new Thread(rightGear.Retract);
            thread.IsBackground = true;
            thread.Start();
            thread = new Thread(leftGear.Retract);
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
