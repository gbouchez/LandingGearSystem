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
        public MainForm()
        {
            InitializeComponent();
            GearSet.Instance.Subscribe(CockpitHandle.Instance);
        }

        private void handleScrollBar_ValueChanged(object sender, EventArgs e)
        {
            CockpitHandle.Instance.State = handleScrollBar.Value == 1 ? HandleState.DOWN : HandleState.UP;
        }
    }
}
