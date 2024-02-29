using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobolgomb
{
    internal class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            MouseClick += SzíneződőGomb_MouseClick;
        }

        private void SzíneződőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
