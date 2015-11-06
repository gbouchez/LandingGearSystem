using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LandingGearSystem;
using LandingGearSystem.Model;


namespace LandingGearSystemTests
{
    [TestClass]
    public class GearTest
    {
        [TestMethod]
        public void openTest()
        {
            GearController gc = new GearController();
            gc.ShouldDeploy = true;
            Gear gear = new Gear(gc);
            gear.Deploy();
            System.Threading.Thread.Sleep(15000);
            Assert.AreEqual(GearState.LOCKDOWN,gear.GearState);
        }

        [TestMethod]
        public void closeTest()
        {
            GearController gc = new GearController();
            gc.ShouldDeploy = true;
            Gear gear = new Gear(gc);
            gear.Retract();
            System.Threading.Thread.Sleep(15000);
            Assert.AreEqual(GearState.LOCKUP, gear.GearState);
        }
    }
}
