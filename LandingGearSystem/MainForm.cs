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
        public GearState FrontGearState = GearState.LOCKUP;
        public GearState RightGearState = GearState.LOCKUP;
        public GearState LeftGearState = GearState.LOCKUP;
        public delegate void UpdateFromGears();
        public UpdateFromGears myDelegate;
        public MainForm()
        {
            InitializeComponent();
            myDelegate = new UpdateFromGears(UpdateFromGearsMethod);
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
        public void UpdateFromGearsMethod()
        {
            switch (LightState)
            {
                case LightState.GREEN:
                    this.pictureLight.Image = Properties.Resources.feu_vert;
                    break;
                case LightState.YELLOW:
                    this.pictureLight.Image = Properties.Resources.feu_orange;
                    break;
                case LightState.NONE:
                    this.pictureLight.Image = Properties.Resources.feu_vide;
                    break;
                case LightState.RED:
                default:
                    this.pictureLight.Image = Properties.Resources.feu_rouge;
                    break;
            }
            UpdateGearPicture(pbFrontGear, FrontGearState);
            UpdateGearPicture(pbLeftGear, LeftGearState);
            UpdateGearPicture(pbRightGear, RightGearState);
        }

        private void UpdateGearPicture(PictureBox pb, GearState state)
        {
            switch (state)
            {
                case GearState.LOCKDOWN:
                    pb.Image = Properties.Resources.gear2_extracted;
                    break;
                case GearState.LOCKUP:
                    pb.Image = Properties.Resources.gear2_retracted;
                    break;
                case GearState.MOVING:
                    pb.Image = Properties.Resources.gear2_moving;
                    break;
            }
        }
    }
}
