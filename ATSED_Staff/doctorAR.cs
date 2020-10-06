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
    public partial class doctorAR : Form
    {
        public doctorAR()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosedPatientsAR diagnosedPatientsAR = new diagnosedPatientsAR("doctorAR");
            diagnosedPatientsAR.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDataAR userDataAR = new userDataAR();
            userDataAR.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removedPatientsAR removedPatientsAR = new removedPatientsAR("doctorAR");
            removedPatientsAR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prioPatientsDAR prioPatientsDAR = new prioPatientsDAR();
            prioPatientsDAR.Show();
        }

        private void doctorAR_Load(object sender, EventArgs e)
        {

        }
    }
}
