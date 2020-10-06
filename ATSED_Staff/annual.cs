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
    public partial class annual : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        string back;
        public annual(string back)
        {
            this.back = back;
            InitializeComponent();
        }

        private void Annual_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" +DateTime.Now.Year.ToString()+ "AND priority = 1;", cn);
            string num = cmd.ExecuteScalar().ToString();
            label1.Text = num;
            double nonum = Int64.Parse(num);
            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + ";", cn);
            string total = cmd.ExecuteScalar().ToString();
            long nototal = Int64.Parse(total);
            double percentage = (100 * nonum) / nototal;
            string result = percentage.ToString("F2");
            label2.Text = result+ "%";

            //
            //orange
            //

            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + "AND priority = 2;", cn);
             num = cmd.ExecuteScalar().ToString();
            label4.Text = num;
             nonum = Int64.Parse(num);
            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + ";", cn);
             total = cmd.ExecuteScalar().ToString();
             percentage = (100 * nonum) / nototal;
             result = percentage.ToString("F2");
             label3.Text = result + "%";

            //
            //yellow
            //

            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + "AND priority = 3;", cn);
            num = cmd.ExecuteScalar().ToString();
            label6.Text = num;
            nonum = Int64.Parse(num);
            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + ";", cn);
            total = cmd.ExecuteScalar().ToString();
            percentage = (100 * nonum) / nototal;
            result = percentage.ToString("F2");
            label5.Text = result + "%";

            //
            //yellow
            //

            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + "AND priority = 4;", cn);
            num = cmd.ExecuteScalar().ToString();
            label8.Text = num;
            nonum = Int64.Parse(num);
            cmd = new SqlCommand
                ("select count(*) from diagnosedPatients where year(time) =" + DateTime.Now.Year.ToString() + ";", cn);
            total = cmd.ExecuteScalar().ToString();
            percentage = (100 * nonum) / nototal;
            result = percentage.ToString("F2");
            label7.Text = result + "%";


            cn.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
            language language = new language();
            language.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (back.Equals("en")) { 
            statistics statistics = new statistics();
            statistics.Show();
            this.Hide();
            }
            else
            {
                statisticsAR statistics = new statisticsAR();
                statistics.Show();
                this.Hide();
            }

        }
    }
}
