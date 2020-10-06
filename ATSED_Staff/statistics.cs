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
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemManager systemManager = new systemManager();
            systemManager.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            annual annual = new annual("en");
            annual.Show();
            this.Hide();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            monthly monthly = new monthly("en");
            monthly.Show();
            this.Hide();
        }
    }
}
