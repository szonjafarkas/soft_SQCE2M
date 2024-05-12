using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Memoria
{
    internal class Kartya : PictureBox
    {
        public int kartyaSzam;

        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Kartya(int sor, int oszlop, int kartyaSzam)
        {
            this.kartyaSzam = kartyaSzam;
            Height = Properties.Settings.Default.kepMeret;
            Width = Properties.Settings.Default.kepMeret;

            Left = oszlop * Properties.Settings.Default.kepTavolsag;
            Top = sor * Properties.Settings.Default.kepTavolsag;

            //Felfordit();
            Lefordit();
            Click += Kartya_Click;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;


        }

        public void Timer_Tick(object? sender, EventArgs e)
        {
            Lefordit();
            timer.Stop();
        }

        private void Kartya_Click(object? sender, EventArgs e)
        {
            Felfordit();
            //timer.Start();

        }

        public void Felfordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.kepKonyvtar + kartyaSzam.ToString() + Properties.Settings.Default.kepUtotag);
        }

        public void Lefordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.kartyaHatter);
        }
    }
}
