using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem.Model
{
    class Door
    {
        public Gear Gear { get; set; }

        public DoorState DoorState { get; set; } = DoorState.LOCKUP;

        public Door(Gear gear)
        {
            Gear = gear;
        }
        /// <summary>
        /// Used to open the door before the <see cref="Gear"/> movement
        /// </summary>
        public void Open()
        {
            DoorState = DoorState.DOWN;
        }
        /// <summary>
        /// Used to open the door after the <see cref="Gear"/> movement
        /// </summary>
        public void Close()
        {
            DoorState = DoorState.LOCKUP;
        }
    }
}
