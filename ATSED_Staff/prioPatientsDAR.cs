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
    public partial class prioPatientsDAR : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");

        public prioPatientsDAR()
        {
            InitializeComponent();
            comboBox1.Items.Add("تحويل لعيادة مختصة");
            comboBox1.Items.Add("إجازة مرضية");
            comboBox1.Items.Add("تقرير أشعة x-ray");
            comboBox1.Items.Add("تقرير الحالة");
            comboBox1.Items.Add("طلب خدمة من الممرض/ـة");

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorAR doctorAR = new doctorAR();
            doctorAR.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void PrioPatientsDAR_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter db = new SqlDataAdapter
                ("select id as 'رقم الهوية', arName as 'الاسم', age as 'العمر', gender as 'الجنس',chiefComplaint as 'الحالة/chief complaint', priority as 'الأولوية', time as 'الوقت' from waitingPatients order by priority;", cn);
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
                ("select id as 'رقم الهوية', arName as 'الاسم', age as 'العمر', gender as 'الجنس',chiefComplaint as 'الحالة/chief complaint', priority as 'الأولوية', time as 'الوقت' from waitingPatients order by priority;", cn);
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
                string s = Convert.ToString(row.Cells["الأولوية"].Value);
                if (s.Equals("1"))
                    row.DefaultCellStyle.BackColor = Color.Red;
                else if (s.Equals("2"))
                    row.DefaultCellStyle.BackColor = Color.Orange;
                else if (s.Equals("3"))
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                else if (s.Equals("4"))
                    row.DefaultCellStyle.BackColor = Color.Green;
                else
                    row.DefaultCellStyle.BackColor = Color.Gray;

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //if row selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //find the value of selected row
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["رقم الهوية"].Value);

                removeReason removeReason = new removeReason(a);
                removeReason.Show();
                cn.Open();

                //move to removed list 
                SqlCommand cmd = new SqlCommand
               ("INSERT INTO removedPatients(id,enName,arName,age,gender,chiefComplaint,priority,time) SELECT id,enName,arNAme,age,gender,chiefComplaint,priority,time FROM waitingPatients WHERE id='" + a + "'; ", cn);
                cmd.ExecuteNonQuery();

                //remove from waiting 
                cmd = new SqlCommand
               ("delete FROM waitingPatients WHERE id='" + a + "'; ", cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //if row selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //find the value of selected row
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["رقم الهوية"].Value);

                cn.Open();

                //move to diagnosed list 
                SqlCommand cmd = new SqlCommand
               ("INSERT INTO diagnosedPatients(id,enName,arNAme,age,gender,chiefComplaint,priority,time) SELECT id,enName,arNAme,age,gender,chiefComplaint,priority,time FROM waitingPatients WHERE id='" + a + "'; ", cn);
                cmd.ExecuteNonQuery();
                if (comboBox1.SelectedItem.ToString().Equals("طلب خدمة من الممرض/ـة"))
                {
                    nurseService nurseService = new nurseService(a);
                    nurseService.Show();
                }
                else if (comboBox1.SelectedIndex > -1)
                {
                    string permission;
                    if (comboBox1.SelectedItem.ToString().Equals("تحويل لعيادة مختصة"))
                    {
                        permission = "Transfer to specialized clinic";
                        cmd = new SqlCommand("INSERT INTO printing(id, time) VALUES(" + a + ", GETDATE());", cn);
                        cmd.ExecuteNonQuery();
                        //**//
                        cmd = new SqlCommand
                        ("update printing set type = '" + permission + "'where time = (select max(time) from printing where id = '" + a + "'); ", cn);
                        cmd.ExecuteNonQuery();
                        TransferForm TransferForm = new TransferForm(a);
                        TransferForm.Show();
                    }
                    else if(comboBox1.SelectedItem.ToString().Equals("إجازة مرضية"))
                    {
                        permission = "Sick leave";
                        cmd = new SqlCommand("INSERT INTO printing(id, time) VALUES(" + a + ", GETDATE());", cn);
                        cmd.ExecuteNonQuery();
                        //**//
                        cmd = new SqlCommand
                        ("update printing set type = '" + permission + "'where time = (select max(time) from printing where id = '" + a + "'); ", cn);
                        cmd.ExecuteNonQuery();
                        SickLeaveForm SickLeaveForm = new SickLeaveForm(a);
                        SickLeaveForm.Show();
                       
                    }
                        
                    else if(comboBox1.SelectedItem.ToString().Equals("تقرير الحالة"))
                    {
                        permission = "Status report";
                        cmd = new SqlCommand("INSERT INTO printing(id, time) VALUES(" + a + ", GETDATE());", cn);
                        cmd.ExecuteNonQuery();
                        //**//
                        cmd = new SqlCommand
                        ("update printing set type = '" + permission + "'where time = (select max(time) from printing where id = '" + a + "'); ", cn);
                        cmd.ExecuteNonQuery();
                        StatusReportForm StatusReportForm = new StatusReportForm(a);
                        StatusReportForm.Show();
                    }

                    else
                    {
                        permission = "x-ray report";
                        cmd = new SqlCommand("INSERT INTO printing(id, time) VALUES(" + a + ", GETDATE());", cn);
                        cmd.ExecuteNonQuery();
                        //**//
                        cmd = new SqlCommand
                        ("update printing set type = '" + permission + "'where time = (select max(time) from printing where id = '" + a + "'); ", cn);
                        cmd.ExecuteNonQuery();
                        xrayForm xrayForm = new xrayForm(a);
                        xrayForm.Show();
                    }

                    //set the value of the permission given
                    cmd = new SqlCommand
          ("update diagnosedPatients set permission = '" + permission+ "'where time = (select max(time) from diagnosedPatients where id = '" + a + "'); ", cn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand
          ("update diagnosedPatients set permission = '" + "NULL" + "'where time = (select max(time) from diagnosedPatients where id = '" + a + "'); ", cn);
                    cmd.ExecuteNonQuery();
                }
                //remove from waiting 
                cmd = new SqlCommand
               ("delete FROM waitingPatients WHERE id='" + a + "'; ", cn);
                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }
    }
}
