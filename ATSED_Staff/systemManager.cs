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
    public partial class systemManager : Form
    {
        public systemManager()
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics statistics = new statistics();
            statistics.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            chosenServices chosenServices = new chosenServices();
            chosenServices.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removedPatients removedPatients = new removedPatients("systemManager");
            removedPatients.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prioPatientsM prioPatientsM = new prioPatientsM();
            prioPatientsM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosedPatients diagnosedPatients = new diagnosedPatients("systemManager");
            diagnosedPatients.Show();

        }
    }
}
