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
    public partial class prioPatientsN : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        public prioPatientsN()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            nurse nurse = new nurse();
            nurse.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language();
            language.Show();
        }

        private void PrioPatientsN_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter db = new SqlDataAdapter
                 ("select id, enName as Name, age, gender,chiefComplaint, priority, time from waitingPatients order by priority;", cn);
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
                 ("select id, enName as Name, age, gender,chiefComplaint, priority, time from waitingPatients order by priority;", cn);
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            //remove auto selection
            dataGridView1.ClearSelection();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //if row selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //find the value of selected row
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["id"].Value);

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

       

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = Convert.ToString(row.Cells["priority"].Value);
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
    }
}