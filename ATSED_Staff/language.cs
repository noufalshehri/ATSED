using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATSED_Staff
{
    public partial class language : Form
    {
        public language()
        {
            InitializeComponent();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userData userData = new userData();
            userData.Show();
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDataAR userDataAR = new userDataAR();
            userDataAR.Show();
        }
    }
}
