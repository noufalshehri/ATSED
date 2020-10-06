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
    public partial class nurse : Form
    {
        public nurse()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userData userData = new userData();
            userData.Show();
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
            removedPatients removedPatients = new removedPatients("nurse");
            removedPatients.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosedPatients diagnosedPatients = new diagnosedPatients("nurse");
            diagnosedPatients.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prioPatientsN prioPatientsN = new prioPatientsN();
            prioPatientsN.Show();
        }
    }
}
