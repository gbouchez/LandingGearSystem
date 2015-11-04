﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public class LandingGear : HydraulicManagedInterface
    {
        private HydraulicCylinder cylinder;
        public HydraulicCylinder Cylinder { get; set; }

        public LandingSet LandingSet { get; set; }

        public LandingGear()
        {
            Cylinder = new HydraulicCylinder();
            Cylinder.RelatedSystem = this;
        }

        public void OnCylinderExtended()
        {
            throw new NotImplementedException();
        }

        public void OnCylinderRetracted()
        {
            throw new NotImplementedException();
        }
    }
}
