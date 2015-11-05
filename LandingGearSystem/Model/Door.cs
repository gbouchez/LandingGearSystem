﻿using System;
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
    }
}