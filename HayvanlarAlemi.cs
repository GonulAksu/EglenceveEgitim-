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
    public partial class HayvanlarAlemi : Form
    {
        public HayvanlarAlemi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "Cat";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Aslan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Köpek";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Kedi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "İnek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Fil";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Leon";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "Elephant";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Cow";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Dog";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(label1.Text=="Fil"&& label2.Text == "Elephant")
            {
                button1.Enabled = false;
                button8.Enabled = false;
                button1.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
            }
            if (label1.Text == "Aslan" && label2.Text == "Leon")
            {
                button2.Enabled = false;
                button7.Enabled = false;
                button2.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }
            if (label1.Text == "Köpek" && label2.Text == "Dog")
            {
                button3.Enabled = false;
                button10.Enabled = false;
                button3.BackColor = Color.Yellow;
                button10.BackColor = Color.Yellow;
            }
            if (label1.Text == "İnek" && label2.Text == "Cow")
            {
                button5.Enabled = false;
                button9.Enabled = false;
                button5.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (label1.Text == "Kedi" && label2.Text == "Cat")
            {
                button4.Enabled = false;
                button6.Enabled = false;
                button4.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
            }
        }
    }
}
