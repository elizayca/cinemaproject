﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaprojesiiiiiii
{
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
           
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //SqlDataAdapter dr = new SqlDataAdapter(cmd);
            SqlCommand cmd = new SqlCommand("Select *from tbl_Admin where adminAd='"+textBox1.Text+"' and adminSifre='"+textBox3.Text+"' and adminSoyad='"+textBox2.Text+"'",con);
          
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                AdminFormu formadminformu = new AdminFormu();
                formadminformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name-surname or password false. ");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
