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
    public partial class statisticsAR : Form
    {
        public statisticsAR()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemManagerAR systemManagerAR = new systemManagerAR();
            systemManagerAR.Show();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            monthly monthly = new monthly("");
            monthly.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            annual annual = new annual("");
            annual.Show();
            this.Hide();
        }
    }
}
