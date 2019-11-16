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
    public partial class Film : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");
        SqlCommand cmd;

        public Film()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtresim.Text = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string kayit = "insert into tbl_Film (FilmAd,FilmTur,FilmSure,FilmYonetmen,FilmIcerik,FilmCast,FilmFragman,FilmAciklama) values (@FilmAd,@FilmTur,@FilmSure,@FilmYonetmen,@FilmIcerik,@FilmCast,@FilmFragman,@FilmAciklama)";
            SqlCommand cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@FilmAd",txtad.Text);
            cmd.Parameters.AddWithValue("@FilmTur", txttur.Text);
            cmd.Parameters.AddWithValue("@FilmSure", txtsure.Text);
            cmd.Parameters.AddWithValue("@FilmYonetmen", txtyonetmen.Text);
            cmd.Parameters.AddWithValue("@FilmIcerik", txticerik.Text);
            cmd.Parameters.AddWithValue("@FilmIcerik", txtcast.Text);
            cmd.Parameters.AddWithValue("@FilmIcerik", txtfragman.Text);
            cmd.Parameters.AddWithValue("@FilmIcerik", txtaciklama.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Film added.");
        }

        private void Film_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_sinemaDataSet1.tbl_Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_FilmTableAdapter1.Fill(this.dbo_sinemaDataSet1.tbl_Film);
            // TODO: Bu kod satırı 'dbo_sinemaDataSet.tbl_Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_FilmTableAdapter.Fill(this.dbo_sinemaDataSet.tbl_Film);

        }
    }
}
