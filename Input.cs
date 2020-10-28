using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Deneme_tez2
{
    class Input
    {
        //mevcut klavyeler düğmesini yükleme
        private static Hashtable keyTable = new Hashtable();
        public static bool KeyPressed(Keys key) // Belirli bir düğmeye basılıp basılmadığını kontrol etmek için
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        //  bir klavye düğmesine basıldığını algılamak için
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
