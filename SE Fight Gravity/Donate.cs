using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Fight_Gravity
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void ButtonDonateLinkClick(object sender, EventArgs e)
        {
            label_donate.ForeColor = Color.Green;
            label_donate.Visible = true;
            Clipboard.SetText("https://www.donationalerts.com/r/belltower182");
        }

        private void DonateLoad(object sender, EventArgs e)
        {
            // Empty

        }
    }
}
