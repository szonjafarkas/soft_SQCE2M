using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobolgomb
{
    internal class Villogógomb : Button
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Villogógomb()
        {
            BackColor = Color.Yellow;
            MouseEnter += Villogógomb_MouseEnter;
            //MouseLeave += Villogógomb_MouseLeave;
            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            t.Stop();
        }

        private void Villogógomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void Villogógomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            t.Interval = 1000;
            t.Start();
        }
    }
}
