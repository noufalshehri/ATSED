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
    public partial class nurseAR : Form
    {
        public nurseAR()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosedPatientsAR diagnosedPatientsAR = new diagnosedPatientsAR("nurseAR");
            diagnosedPatientsAR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removedPatientsAR removedPatientsAR = new removedPatientsAR("nurseAR");
            removedPatientsAR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prioPatientsNAR prioPatientsNAR = new prioPatientsNAR();
            prioPatientsNAR.Show();
        }
    }
}
