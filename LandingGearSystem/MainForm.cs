using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LandingGearSystem.Model;

namespace LandingGearSystem
{
    public partial class MainForm : Form
    {
        public LightState LightState = LightState.NONE;
        public delegate void UpdateLights();
        public UpdateLights myDelegate;
        public MainForm()
        {
            InitializeComponent();
            myDelegate = new UpdateLights(UpdateLightsMethod);
            GearController.Instance.Form = this;
        }

        private void handleScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (handleScrollBar.Value == 1)
            {
                GearController.Instance.Deploy();
            }
            else
            {
                GearController.Instance.Retract();
            }
        }
        public void UpdateLightsMethod()
        {
            switch (LightState)
            {
                case LightState.GREEN:

                    this.pictureLight.Image = global::LandingGearSystem.Properties.Resources.feu_vert;
                    break;
            }
            Console.WriteLine("test");
        }
    }
}
