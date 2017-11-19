using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobEstimator
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void inputInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new InputInfo().Show();
            this.Hide();
        }

        private void howItWorks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new howItWorks().Show();
            this.Hide();
        }

        private void btnExitHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
