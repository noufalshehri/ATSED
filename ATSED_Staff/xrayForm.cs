﻿using System;
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
    public partial class xrayForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        string id;
        public xrayForm(string id)
        {
            this.id = id;
            InitializeComponent();
            label25.Text = id;
            label28.Text = id;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select enName from diagnosedPatients where id='" + id + "';", cn);
            string s = cmd.ExecuteScalar().ToString();
            label27.Text = s;
            cmd = new SqlCommand("select arName from diagnosedPatients where id='" + id + "';", cn);
            s = cmd.ExecuteScalar().ToString();
            label24.Text = s;
            cmd = new SqlCommand("select age from diagnosedPatients where id='" + id + "';", cn);
            s = cmd.ExecuteScalar().ToString();
            label26.Text = s;
            label38.Text = s;

            cn.Close();
        }

        private void StatusReportForm_Load(object sender, EventArgs e)
        {


        }

        private void submit_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE printing SET ar_nat ='" + textBox4.Text + "' where time = (select max(time) from printing where id = " + id + " );", cn);
            cmd.ExecuteNonQuery();
            //**//
            cmd = new SqlCommand("UPDATE printing SET nat ='" + textBox1.Text + "' where time = (select max(time) from printing where id = " + id + " );", cn);
            cmd.ExecuteNonQuery();

            //**//
            cmd = new SqlCommand("UPDATE printing SET xray_details ='" + textBox6.Text + "' where time = (select max(time) from printing where id = " + id + " );", cn);
            cmd.ExecuteNonQuery();
            //**//
            cmd = new SqlCommand("UPDATE printing SET doctor ='" + textBox14.Text + "' where time = (select max(time) from printing where id = " + id + " );", cn);
            cmd.ExecuteNonQuery();
            //**//
            cmd = new SqlCommand("UPDATE printing SET ar_doctor ='" + textBox10.Text + "' where time = (select max(time) from printing where id = " + id + " );", cn);
            cmd.ExecuteNonQuery();

            cn.Close();
            this.Close();
        }


    }
}
