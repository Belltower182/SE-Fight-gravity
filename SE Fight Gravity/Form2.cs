using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Fight_Gravity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void closeinfo_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void github_button_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("https://github.com/Belltower182/SE-Fight-gravity");
        }

        private void email_button_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
            label3.Visible = true;
            Clipboard.SetText("https://github.com/Belltower182/SE-Fight-gravity");
        }
    }
}
