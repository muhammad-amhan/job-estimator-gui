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
    public partial class howItWorks : Form
    {
        public howItWorks()
        {
            InitializeComponent();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
