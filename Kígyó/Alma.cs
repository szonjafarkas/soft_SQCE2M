using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kígyó
{
    
    internal class Alma : PictureBox
    {
        public static int Méret = 20;
        public Alma()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Red;
        }

    }
}
