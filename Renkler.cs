using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_tez2
{
    public partial class Renkler : Form
    {
        public Renkler()
        {
            InitializeComponent();
        }

        private void Renkler_Load(object sender, EventArgs e)
        {
            renksec();

        }

        void renksec()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 5);
            if (sayi == 0) lblRenk.Text = "Kırmızı";
            if (sayi == 1) lblRenk.Text = "Mavi";
            if (sayi == 2) lblRenk.Text = "Sarı";
            if (sayi == 3) lblRenk.Text = "Turuncu";
            if (sayi == 4) lblRenk.Text = "Mor";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgrbar.Value--;
            lblsayac.Text = pgrbar.Value.ToString();
            if (lblsayac.Text == "0") {
                timer1.Enabled = false;
                btnkırmızı.Enabled = false;
                btnmavi.Enabled = false;
                btnmor.Enabled = false;
                btnsarı.Enabled = false;
                btnturuncu.Enabled = false;

            }
                
        }

        private void btnkırmızı_Click(object sender, EventArgs e)
        {
            if (lblRenk.Text == "Kırmızı")
            {
                lblskor.Text = (Convert.ToInt16(lblskor.Text) + 1).ToString();
                renksec();
            }
            else
            {
                renksec();
            }
        }

        private void btnmavi_Click(object sender, EventArgs e)
        {
            if (lblRenk.Text == "Mavi")
            {
                lblskor.Text = (Convert.ToInt16(lblskor.Text) + 1).ToString();
                renksec();
            }
            else
            {
                renksec();
            }
        }

        private void btnsarı_Click(object sender, EventArgs e)
        {
            if (lblRenk.Text == "Sarı")
            {
                lblskor.Text = (Convert.ToInt16(lblskor.Text) + 1).ToString();
                renksec();
            }
            else
            {
                renksec();
            }
        }

        private void btnturuncu_Click(object sender, EventArgs e)
        {
            if (lblRenk.Text == "Turuncu")
            {
                lblskor.Text = (Convert.ToInt16(lblskor.Text) + 1).ToString();
                renksec();
            }
            else
            {
                renksec();
            }
        }

        private void btnmor_Click(object sender, EventArgs e)
        {
            if (lblRenk.Text == "Mor")
            {
                lblskor.Text = (Convert.ToInt16(lblskor.Text) + 1).ToString();
                renksec();
            }
            else
            {
                renksec();
            }
        }
    }
}
