using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingGearSystem
{
    public class MainSystem
    {
        private static MainSystem instance;
        public static MainSystem Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new MainSystem();
                }
                return instance;
            }
        }

        public void InitiateLandingSequence()
        {
            OpenDoors();
            ExtendLandingGears();
            CloseDoors();
        }

        private void ExtendLandingGears()
        {
            throw new NotImplementedException();
        }

        public void InitiateRetractionSequence()
        {
            CloseDoors();
            RetractLandingGears();
            OpenDoors();
        }

        private void RetractLandingGears()
        {
            throw new NotImplementedException();
        }

        private void CloseDoors()
        {
            throw new NotImplementedException();
        }

        private void OpenDoors()
        {
            throw new NotImplementedException();
        }
    }
}
