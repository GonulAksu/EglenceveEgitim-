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
    public partial class HafızaOyunu : Form
    {
        Image[] resimler =
        {
            Properties.Resources._1,
             Properties.Resources._2,
              Properties.Resources._3,
               Properties.Resources._4,
                Properties.Resources._5,
                 Properties.Resources._6,
                  Properties.Resources._7,
                   Properties.Resources._8


        };
        //resimleri karıştırmayacağız indexleri karıştıracağız

        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        PictureBox ilkkutu;
        int ilkindeks, bulunan, deneme;
        public HafızaOyunu()
        {
            InitializeComponent();
        }

        private void HafızaOyunu_Load(object sender, EventArgs e)
        {
            resimlerikaristir();
        }

        private void resimlerikaristir()
        {
            for(int i = 0; i < 16; i++)
            { Random rnd = new Random();
                int sayi = rnd.Next(16);

                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }

        private void picturebox(object sender, EventArgs e)
        {//sender=gonderen
            //tıkladığımız kutuyu picturebox kutu olarak adlandırdım
            PictureBox kutu = (PictureBox)sender;
            //sender'ı picturebox'a cevireceğiz yani hangi kutuya trtıklandığını bileceğiz
            int kutuNO = int.Parse(kutu.Name.Substring(10)) ;
            //hangi kutuya tıkladığımızı adından anlayabilirz "picturebox10" 10.karakterden sonrasını almalıyız
            int indeksNo=indeksler[kutuNO-1];
            //kutunumarası 16 ama biz indeksler de 15 aldık
            //indeksno ile hangi resmin ona ait oldugunu öğrendik ve 
            //aşagıdaki satırda da bunu gösterdik
            kutu.Image = resimler[indeksNo];
            kutu.Refresh();

            //bu metotdan çıktığımızda bu kutuyu kaybetmemiz için kutuyu bir yerde tutacağız

            if (ilkkutu == null) {
                ilkkutu = kutu;
                ilkindeks = indeksNo;
                deneme++;
                //ilk kutunun bilgilerini aldık
            }
            else

            {
                System.Threading.Thread.Sleep(1000);
                ilkkutu.Image = null;
                kutu.Image = null;

                if(ilkindeks==indeksNo)
                {
                    //tıkladıgımız resimlerin indeksleri aynı ise bulmuş oluyoruz

                    bulunan++;
                    ilkkutu.Visible = false;
                    kutu.Visible = false;


                    if (bulunan == 8) {

                        MessageBox.Show("Tebrikler :)" + deneme + " denemede buldunuz...");

                        bulunan = 0;
                        deneme = 0;
                        //görünmez olan pictureboxları tekrar görünğr hale getirmeliyiz
                        //formumuza eklediğimiz kontrolleri dolaşacğız
                        foreach(Control kontrol in Controls)
                        {
                            kontrol.Visible = true;

                        }
                        resimlerikaristir();

                    }

                }
                ilkkutu = null;


            }

        }
    }
}
