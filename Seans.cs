using System;
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
    public partial class Seans : Form
    {

        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");
        SqlCommand cmd;

        public Seans()
        {
            InitializeComponent();
        }


        private void Seans_Load_1(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SehirAd FROM tbl_Sehir";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["SehirAd"].ToString());
            }

            con.Close();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combofilm.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT FilmAd FROM tbl_Film";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                combofilm.Items.Add(dr["FilmAd"].ToString());
                 
            }

            combofilm.Text = "Films";
            comboseans.Text = "Seances";
            combotarih.Text = "Dates";
            
            con.Close();
            //**************************
            //**************************
            comboseans.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SeansSaat FROM tbl_Seans";
            cmd.ExecuteNonQuery();
            DataTable dt3 = new DataTable();

            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                comboseans.Items.Add(dr["SeansSaat"].ToString());
            }

            con.Close();
            //***************************
            //***************************
            combotarih.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SeansTarih FROM tbl_Seans";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                combotarih.Items.Add(dr["SeansTarih"].ToString());
            }

            con.Close();

        }

       
       private void yenile()
        {
            comboseans.Refresh();
            combotarih.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void combofilm_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("SELECT * FROM Tbl_Film where FilmAd='" + combofilm.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string filmad = (string)dr["FilmAd"].ToString();
               // textfilm.Text = filmad;
            }
            con.Close();


        }

        private void combotarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Tbl_Seans where SeansTarih='" + combotarih.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string tarih = (string)dr["SeansTarih"].ToString();
                //textdate.Text = tarih;
            }
            con.Close();

        }

        private void comboseans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Tbl_Seans where SeansSaat='" + comboseans.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string seans = (string)dr["SeansSaat"].ToString();
               
            }
            con.Close();
        }

        private void buttonseansekle_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string kayit = "insert into tbl_Seans (SeansSaat,SeansTarih) values (@SeansSaat,@SeansTarih)";
            SqlCommand cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@SeansSaat",txtseansekle.Text);
            cmd.Parameters.AddWithValue("@SeansTarih", txtdateekle.Text);
           // yenile();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added");
           
           

        }
        private void circularButton1_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string sil = "DELETE FROM tbl_Seans where SeansSaat=@SeansSaat,SeansTarih=@SeansTarih";
            SqlCommand cmd = new SqlCommand(sil,con);

            cmd.Parameters.AddWithValue("@SeansSaat",comboseans.SelectedItem);
            cmd.Parameters.AddWithValue("@SeansTarih",combotarih.SelectedItem);
           

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");

          

        }
        private void txtdateekle_TextChanged(object sender, EventArgs e)
        {

        }

        


        
    }
}
