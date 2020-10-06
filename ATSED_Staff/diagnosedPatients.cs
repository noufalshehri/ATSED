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
    public partial class diagnosedPatients : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        public string back;
        public diagnosedPatients(string s)
        {
            InitializeComponent();
            back = s;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            switch (back)
            {
                case "systemManager":
                    this.Hide();
                    systemManager systemManager = new systemManager();
                    systemManager.Show();
                    break;
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

            }

        }

        private void DiagnosedPatients_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter db = new SqlDataAdapter
                ("select id, enName as Name, age, gender,chiefComplaint, priority, time, permission from diagnosedPatients", cn);
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            //remove auto selection
            dataGridView1.ClearSelection();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter db = new SqlDataAdapter
                ("select id, enName as Name, age, gender,chiefComplaint, priority, time, permission from diagnosedPatients", cn);
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            //remove auto selection
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = Convert.ToString(row.Cells["permission"].Value);
                if (!s.Equals("Transfer to specialized clinic")&&!s.Equals("Sick leave") && !s.Equals("x-ray report") && !s.Equals("Status report") && ! s.Equals("NULL"))
                    row.DefaultCellStyle.BackColor = Color.Violet;
              
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }
    }
}
