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
using System.Net.Mail;

namespace sinemaprojesiiiiiii
{
    public partial class BiletAl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");
        SqlCommand cmd;
       

        public BiletAl()
        {
            InitializeComponent();
        }


    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.Text = "Select one of the answers";
                comboBox1.SelectedIndex = comboBox1.SelectedIndex;
            }
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            KoltukSecimi form = new KoltukSecimi();
            form.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.TextLength != 11)
            //{
            //    MessageBox.Show("Identity number must include 11 number ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void label12_Click(object sender, EventArgs e)
        {
          //  label12.Text = filmad;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { e.Handled = true; }
            else
            { e.Handled = false; }
        }

        private void BiletAl_Load(object sender, EventArgs e)
        {
          
                
            


            comboBox1.Items.Clear();
            this.comboBox1.Text = "Seç";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT FilmAd FROM tbl_Film";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            

            foreach (DataRow dr in dt.Rows)
            {
                //dr["FilmAd"] = "Select your film";
                comboBox1.Items.Add(dr["FilmAd"].ToString());
               
            }
            con.Close();




            SqlDataAdapter verial = new SqlDataAdapter("Select SehirAd from tbl_Sehir", con);
            DataSet dset = new DataSet();
            verial.Fill(dset);

            foreach (DataRow dr in dset.Tables[0].Rows)
            {
                comboBox4.Items.Add(dr["SehirAd"].ToString());
            }




            SqlDataAdapter verial2 = new SqlDataAdapter("Select SeansSaat from tbl_Seans", con);
            DataSet dset2 = new DataSet();
            verial2.Fill(dset2);
            foreach (DataRow dr in dset2.Tables[0].Rows)
            {
                comboBox2.Items.Add(dr["SeansSaat"].ToString());
            }


           

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBox4.Items.Clear();

            //con.Open();
            //cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT SehirAd FROM tbl_Sehir";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    comboBox4.Items.Add(dr["SehirAd"].ToString());
            //}
            //con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        int sayi;
        Random rnd = new Random();


        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string kayit = "insert into tbl_Odeme (KullaniciAdSoyad,KullaniciEmail,KullaniciTc,KullaniciKrediKart," +
                "KullaniciSonKullanma,KullaniciGuvenlikNo,KullaniciTelefon)" +
                " values (@KullaniciAdSoyad,@KullaniciEmail,@KullaniciTc,@KullaniciKrediKart,@KullaniciSonKullanma," +
                "@KullaniciGuvenlikNo,@KullaniciTelefon)";
            SqlCommand cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@KullaniciAdSoyad", textBox1.Text);
            cmd.Parameters.AddWithValue("@KullaniciEmail", textBox2.Text);
            cmd.Parameters.AddWithValue("@KullaniciTc", textBox3.Text);
            cmd.Parameters.AddWithValue("@KullaniciKrediKart", textBox4.Text);
            cmd.Parameters.AddWithValue("@KullaniciSonKullanma", textBox6.Text);
            cmd.Parameters.AddWithValue("@KullaniciGuvenlikNo", textBox7.Text);
            cmd.Parameters.AddWithValue("@KullaniciTelefon", textBox5.Text);
           


            cmd.ExecuteNonQuery();
            con.Close();

          

            MessageBox.Show("tebrik");




//********************

          
                sayi = rnd.Next(10000, 90000);
                MailMessage msj = new MailMessage();
                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential("CineTicket.adu@hotmail.com","cineticket123");
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                object userState = msj;



                msj.To.Add(textBox2.Text);
                msj.From = new MailAddress("CineTicket.adu@hotmail.com","CineTicket");
                msj.Subject = "CineTicket -> Güvenlik Kodu";
            
                msj.Body = sayi.ToString()+ " Biletinizin onayı için lütfen kodu CineTicket sayfasına doğru bir şekilde giriniz.";
                
                
                client.Send(msj);
                MessageBox.Show("Doğrulama Kodu Gönderildi");

           


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(textBoxdogrulama.Text == sayi.ToString())
            {
                label14.Text = "Güvenlik Kodu Doğru";
                label14.ForeColor = Color.Green;
            }
            else
            {
                label14.Text = "Güvenlik Kodu yanlış";
            }


        }
    }
}
