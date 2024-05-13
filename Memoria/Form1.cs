using System.Windows.Forms;

namespace Memoria
{
    public partial class Form1 : Form
    {
        //Kartya elozoKartya;
        Kartya elsoKartya = null;
        Kartya masodikKartya = null;
        int talalt = 0;
        int nem_talalt = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.hatterkep);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;
            label3.Text = talalt.ToString();
            label4.Text = nem_talalt.ToString();

            int sorszam = 0;

            int[] t = Keveres(16);

            for (int s = 0; s < 4; s++)
            {
                for (int o = 0; o < 4; o++)
                {
                    Kartya k = new Kartya(s, o, t[sorszam]);
                    Controls.Add(k);
                    k.Left = Width / 2 - ((2 - o) * Properties.Settings.Default.kepMeret + (2 - o) * Properties.Settings.Default.kepTavolsag);
                    k.Top = Height / 2 - ((2 - s) * Properties.Settings.Default.kepMeret + (2 - s) * Properties.Settings.Default.kepTavolsag);
                    k.Click += K_Click;

                    sorszam++;

                }

            }

            int[] Keveres(int kartyaSzam)
            {
                int[] tomb = new int[kartyaSzam];
                for (int i = 0; i < kartyaSzam / 2; i++)
                {

                    tomb[i] = i + 1;
                    tomb[i + kartyaSzam / 2] = i + 1;
                }

                Random rnd = new Random();

                for (int i = 0; i < kartyaSzam; i++)
                {
                    int egyik = rnd.Next(kartyaSzam);
                    int masik = rnd.Next(kartyaSzam);

                    int koztes = tomb[egyik];
                    tomb[egyik] = tomb[masik];
                    tomb[masik] = koztes;
                }

                return tomb;
            }
        }

        private void K_Click(object? sender, EventArgs e)
        {


            if (sender is Kartya)
            {
                Kartya k = (Kartya)sender;



                // nem ugyanaz a kártya, mint az elõzõ
                if (elsoKartya != null && k == elsoKartya)
                    return;

                if (elsoKartya == null)
                {
                    elsoKartya = k;


                }
                else if (masodikKartya == null)
                {
                    masodikKartya = k;





                    // Ellenõrizzük, hogy a két kártya azonos
                    if (elsoKartya.kartyaSzam == masodikKartya.kartyaSzam)
                    {
                        elsoKartya.Visible = false;
                        masodikKartya.Visible = false;
                        elsoKartya = null;
                        masodikKartya = null;
                        talalt++;
                        label3.Text = talalt.ToString();


                    }
                    else
                    {
                        elsoKartya.timer.Start();
                        masodikKartya.timer.Start();

                        elsoKartya = null;
                        masodikKartya = null;
                        nem_talalt++;
                        label4.Text = nem_talalt.ToString();
                    }



                }





            }


        }
        int seconds = 0;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label5.Text = seconds.ToString();
        }
    }
}



