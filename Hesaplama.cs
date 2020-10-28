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
    public partial class Hesaplama : Form
    {
        public Hesaplama()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc;
            if (label3.Text == "+")
            {
                sonuc = Convert.ToInt32(label1.Text)+Convert.ToInt32(label2.Text);
                label6.Text = sonuc.ToString();
            }
            if (label3.Text == "-")
            {
                sonuc = Convert.ToInt32(label1.Text) - Convert.ToInt32(label2.Text);
                label6.Text = sonuc.ToString();
            }
            if (label3.Text == "*")
            {
                sonuc = Convert.ToInt32(label1.Text) * Convert.ToInt32(label2.Text);
                label6.Text = sonuc.ToString();
            }
            if (label3.Text == "/")
            {
                sonuc = Convert.ToInt32(label1.Text) / Convert.ToInt32(label2.Text);
                label6.Text = sonuc.ToString();
            }
            if (label6.Text == textBox1.Text)
            {
                label7.Text = "Tebrikler";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);
            int c = rnd.Next(1, 5);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
         if( c==1)
            {
                label3.Text = "+";
            }
            if (c == 2)
            {
                label3.Text = "-";
            }
            if (c == 3)
            {
                label3.Text = "*";
            }
            if (c == 1)
            {
                label3.Text = "/";
            }

        }
    }
}
