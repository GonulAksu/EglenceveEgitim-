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
    public partial class YilanOyunu : Form
    {
        private List<yuvarlak> Yilan = new List<yuvarlak>();
        private yuvarlak yem = new yuvarlak();


        public YilanOyunu()
        {
            InitializeComponent();

           // ayarı varsayılana ayarla

            new ayarlar();

            //oyun hızını ve başlangıç ​​zamanlayıcısını ayarlama
            oyunSüresi.Interval = 1000 / ayarlar.Hız;
            oyunSüresi.Tick += UpdateScreen;
            oyunSüresi.Start();
            //yeni oyun 
            Oyun();

        }

        private void Oyun()
        {
            lblOyunBitti.Visible = false;

            new ayarlar();

           // yeni oyuncu nesnesi oluştur
            Yilan.Clear();
            yuvarlak bas = new yuvarlak();
           bas. X = 10;
            bas.Y = 5;
            Yilan.Add(bas);

            lbskor.Text = ayarlar.Skor.ToString();
            yemUret();
        }
        //rastgele yem üretme 
        private void yemUret()
        {
            int maxXPos = pb.Size.Width / ayarlar.Boyu;
            int maxYPos = pb.Size.Height / ayarlar.Yükseklik;

            Random random = new Random();
            yem = new yuvarlak();

            yem.X = random.Next(0, maxXPos);
            yem.Y = random.Next(0, maxYPos);
            

        }
        private void UpdateScreen(object sender , EventArgs e)
        {
            //oyun bitti mi?
            if (ayarlar.oyunBitti==true)
            {
               // girişin basılı olup olmadığını kontrol et
                if (Input.KeyPressed(Keys.Enter))
                {
                    Oyun();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && ayarlar.direction != Direction.Left)
                    ayarlar.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && ayarlar.direction != Direction.Right)
                    ayarlar.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && ayarlar.direction != Direction.Down)
                    ayarlar.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && ayarlar.direction != Direction.Up)
                    ayarlar.direction = Direction.Down;

                MovePlayer();
            }
            pb.Invalidate();
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!ayarlar.oyunBitti)
            {

                Brush yilanRenk;

                for (int i = 0; i < Yilan.Count; i++)
                {
                 
                    if (i == 0)

                        yilanRenk = Brushes.Black; //yılanın başının rengi
                    else
                        yilanRenk = Brushes.Green;//yılanın yem yedikçe büyüyen kısmının rengi
                    //yılan çizimi
                    canvas.FillEllipse(yilanRenk,
                        new Rectangle(Yilan[i].X * ayarlar.Boyu,
                        Yilan[i].Y * ayarlar.Yükseklik,
                        ayarlar.Boyu, ayarlar.Yükseklik));

                    //yem çizimi
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(yem.X * ayarlar.Boyu,
                        yem.Y * ayarlar.Yükseklik,
                        ayarlar.Boyu, ayarlar.Yükseklik));
                }

            }
            else
            {
                string oyunBitti = "Oyun bitti \n Skor :" + ayarlar.Skor + "\n Tekrar denemek için enter tuşuna basın.";
                lblOyunBitti.Text = oyunBitti;
                lblOyunBitti.Visible = true;
            }
        }
        private void MovePlayer()
        {
            for (int i = Yilan.Count - 1; i >= 0; i--)
            {
                //baş hareketi
                if (i == 0)
                {
                    switch (ayarlar.direction)
                    {
                        case Direction.Right:
                            Yilan[i].X++;
                            break;
                        case Direction.Left:
                            Yilan[i].X--;
                            break;
                        case Direction.Up:
                            Yilan[i].Y--;
                            break;
                        case Direction.Down:
                            Yilan[i].Y++;
                            break;
                    }
                    int maxXPos = pb.Size.Width / ayarlar.Boyu;
                    int maxYPos = pb.Size.Height / ayarlar.Yükseklik;

                    if (Yilan[i].X < 0 || Yilan[i].Y < 0
                        || Yilan[i].X >= maxXPos || Yilan[i].Y >= maxYPos)
                    {
                        Yenildin();
                    }

                    for (int j = 1; j < Yilan.Count; j++)
                    {
                        if (Yilan[i].X == Yilan[j].X &&
                            Yilan[i].Y == Yilan[j].Y)
                        {
                            Yenildin();
                        }
                    }

                    if (Yilan[0].X == yem.X && Yilan[0].Y == yem.Y)
                    {
                        ye();
                    }
                }
                else
                {
                    //vücud hareketi
                    Yilan[i].X = Yilan[i - 1].X;
                    Yilan[i].Y = Yilan[i - 1].Y;

                }
            }
        }

        private void YilanOyunu_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void YilanOyunu_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void ye()
        {
            //vücuda kaynak ekle
            yuvarlak yem = new yuvarlak();

            yem.X = Yilan[Yilan.Count - 1].X;
            yem.Y = Yilan[Yilan.Count - 1].Y;

         
            Yilan.Add(yem);

            //skor güncelle
            ayarlar.Skor += ayarlar.Point;
            lbskor.Text = ayarlar.Skor.ToString();

            yemUret(); 

        }

        private void Yenildin()
        {
            ayarlar.oyunBitti = true;
        }
    }
}
