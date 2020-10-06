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
    public partial class diagnosedPatientsAR : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");

        public string back;
        public diagnosedPatientsAR(string s)
        {
            InitializeComponent();
            back = s;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            switch (back)
            {
                case "systemManagerAR":
                    this.Hide();
                    systemManagerAR systemManagerAR = new systemManagerAR();
                    systemManagerAR.Show();
                    break;
                case "doctorAR":
                    this.Hide();
                    doctorAR doctorAR = new doctorAR();
                    doctorAR.Show();
                    break;
                case "nurseAR":
                    this.Hide();
                    nurseAR nurseAR = new nurseAR();
                    nurseAR.Show();
                    break;

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void DiagnosedPatientsAR_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter db = new SqlDataAdapter
                ("select id as 'رقم الهوية', arName as 'الاسم', age as 'العمر', gender as 'الجنس',chiefComplaint as 'الحالة/chief complaint', priority as 'الأولوية', time as 'الوقت' , permission as 'الأذن' from diagnosedPatients", cn);
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
                ("select id as 'رقم الهوية', arName as 'الاسم', age as 'العمر', gender as 'الجنس',chiefComplaint as 'الحالة/chief complaint', priority as 'الأولوية', time as 'الوقت' , permission as 'الأذن' from diagnosedPatients", cn);
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
                string s = Convert.ToString(row.Cells["الأذن"].Value);
                if (!s.Equals("Transfer to specialized clinic") && !s.Equals("Sick leave") && !s.Equals("x-ray report") && !s.Equals("Status report") && !s.Equals("NULL"))
                    row.DefaultCellStyle.BackColor = Color.Violet;

            }
        }
    }
}
