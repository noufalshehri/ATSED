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
    public partial class systemManagerAR : Form
    {
        public systemManagerAR()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            chosenServicesAR chosenServicesAR = new chosenServicesAR();
            chosenServicesAR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removedPatientsAR removedPatientsAR = new removedPatientsAR("systemManagerAR");
            removedPatientsAR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prioPatientsMAR prioPatientsMAR = new prioPatientsMAR();
            prioPatientsMAR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosedPatientsAR diagnosedPatientsAR = new diagnosedPatientsAR("systemManagerAR");
            diagnosedPatientsAR.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            statisticsAR statisticsAR = new statisticsAR();
            statisticsAR.Show();
        }
    }
}
