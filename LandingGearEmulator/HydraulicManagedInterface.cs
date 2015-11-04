using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearEmulator
{
    public interface HydraulicManagedInterface
    {
        HydraulicCylinder Cylinder { get; set; }

        void OnCylinderExtended();

        void OnCylinderRetracted();
    }
}
