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
        public MainForm Form;
        private static GearController instance;
        private Gear frontGear;
        private Gear rightGear;
        private Gear leftGear;
        private GearObserver frontGearObserver = new GearObserver();
        private GearObserver rightGearObserver = new GearObserver();
        private GearObserver leftGearObserver  = new GearObserver();

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
            Form.LightState = LightState.GREEN;
            Form.Invoke(Form.myDelegate);
        }

        public GearController()
        {
            frontGear = new Gear(this);
            frontGearObserver.Subscribe(frontGear);
            frontGearObserver.Controller = this;
            rightGear = new Gear(this);
            rightGearObserver.Subscribe(rightGear);
            rightGearObserver.Controller = this;
            leftGear = new Gear(this);
            leftGearObserver.Subscribe(leftGear);
            leftGearObserver.Controller = this;
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
