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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArabaOyunu ac2 = new ArabaOyunu();
            ac2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            HafızaOyunu ac2 = new HafızaOyunu();
            ac2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YilanOyunu ac2 = new YilanOyunu();
            ac2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Labirentcs ac2 = new Labirentcs();
            ac2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Renkler ac2 = new Renkler();
            ac2.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HayvanlarAlemi ac2 = new HayvanlarAlemi();
            ac2.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Hesaplama ac2 = new Hesaplama();
            ac2.ShowDialog();
        }
    }
}
