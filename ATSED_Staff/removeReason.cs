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
    public partial class removeReason : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        string id;
        public removeReason(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand
           ("update removedPatients set reason = '" +textBox1.Text+ "' where time = (select max(time) from removedPatients where id ='" + id + "');", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            this.Close();

        }
    }
}
