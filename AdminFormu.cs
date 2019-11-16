using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaprojesiiiiiii
{
    public partial class AdminFormu : Form
    {
        public AdminFormu()
        {
            InitializeComponent();
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            Seans formseans = new Seans();
            formseans.Show();
            this.Hide();

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            Salon formsalon = new Salon();
            formsalon.Show();
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Film formfilmler = new Film();
            formfilmler.Show();
            this.Hide();
        }
    }
}
