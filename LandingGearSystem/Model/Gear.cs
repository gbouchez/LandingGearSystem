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
        public Door Door { get; set; }

        public GearController Controller { get; set; }

        public GearState GearState { get; set; }

        public Gear(GearController controller)
        {
            Controller = controller;
            Door = new Door(this);
        }

        public void Deploy()
        {
            if (GearState == GearState.LOCKDOWN)
            {
                return;
            }
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            if (Door.DoorState != DoorState.DOWN)
            {
                Door.Open();
            }
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            GearState = GearState.MOVING;
            Thread.Sleep(1000);
            GearState = GearState.LOCKDOWN;
            if (!Controller.ShouldDeploy)
            {
                return;
            }
            if (Door.DoorState != DoorState.LOCKUP)
            {
                Door.Close();
            }
            Controller.ShouldDeploy = false;
            return;
        }

        public void Retract()
        {
            if (GearState == GearState.LOCKUP)
            {
                return;
            }
            if (!Controller.ShouldRetract)
            {
                return;
            }
            if (Door.DoorState != DoorState.DOWN)
            {
                Door.Open();
            }
            if (!Controller.ShouldRetract)
            {
                return;
            }
            GearState = GearState.MOVING;
            Thread.Sleep(1000);
            GearState = GearState.LOCKUP;
            if (!Controller.ShouldRetract)
            {
                return;
            }
            if (Door.DoorState != DoorState.LOCKUP)
            {
                Door.Close();
            }
            Controller.ShouldRetract = false;
            return;
        }
    }
}
