using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATSED_Staff
{
    public partial class userData : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");

        public userData()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            this.ActiveControl = idTextBox;
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand
                ("select count(*) from hospitalStaff where userName='" + idTextBox.Text.Trim() + "';", cn);
            string u = cmd.ExecuteScalar().ToString();
            if (u.Equals("1"))
            {
                cmd = new SqlCommand
                        ("select password from hospitalStaff where userName='" + idTextBox.Text.Trim() + "';", cn);
                string s = cmd.ExecuteScalar().ToString();

                string password = passTextBox.Text.Trim();
                if (password.Equals(s))
                {
                    cmd = new SqlCommand
                    ("select jobTitle from hospitalStaff where userName='" + idTextBox.Text.Trim() + "';", cn);
                    string jobTitle = cmd.ExecuteScalar().ToString();
                    switch (jobTitle)
                    {
                        case "doctor":
                            this.Hide();
                            doctor doctor = new doctor();
                            doctor.Show();
                            break;
                        case "nurse":
                            this.Hide();
                            nurse nurse = new nurse();
                            nurse.Show();
                            break;
                        case "manager":
                            this.Hide();
                            systemManager systemManager = new systemManager();
                            systemManager.Show();
                            break;
                    }

                }
                else
                    MessageBox.Show("wrong password");
            }
            else
                MessageBox.Show("user name does not exist");

            cn.Close();

        }
    }
}
