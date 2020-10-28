using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_tez2
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    class ayarlar
    {
        public static int Boyu { get; set; }
        public static int Yükseklik { get; set; }
        public static int Hız { get; set; }
        public static int Skor { get; set; }
        public static int Point { get; set; }
        public static bool oyunBitti { get; set; }
        public static Direction direction { get; set; }


        public ayarlar()
        {
            Boyu = 16;
            Yükseklik = 16;
            Hız = 13;
            Skor = 0;
            Point = 10;
            oyunBitti = false;
            direction = Direction.Down;



        }
    }
}
