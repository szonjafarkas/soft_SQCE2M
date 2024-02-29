using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobolgomb
{
    internal class SzámolóGomb : Button
    {
        int szám;
        
        public SzámolóGomb()
        {
            szám = 1;
            MouseClick += SzámolóGomb_MouseClick;
            Text = szám.ToString();
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szám ++ ;
            if (szám==6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
