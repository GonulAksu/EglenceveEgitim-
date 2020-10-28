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
    public partial class Labirentcs : Form
    {
        public Labirentcs()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara Çarptınız.Oyun Bitti!..");
            Application.Exit();
        }


        private void label21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız.");
        }
    }
}
