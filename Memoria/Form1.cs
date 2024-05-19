using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Memoria
{
    public partial class Form1 : Form
    {
        //Kartya elozoKartya;
        Kartya elsoKartya = null;
        Kartya masodikKartya = null;
        //HashSet<Kartya> cards;
        int talalt = 0;
        int nem_talalt = 0;
        int nehezseg;
        int seconds = 0;

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
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Visible = false;
            pictureBox1.Image = Bitmap.FromFile(Properties.Settings.Default.grat);
        }

        private void K_Click(object? sender, EventArgs e)
        {
            //if (sender is Kartya)
            //{
            //    Kartya k = (Kartya)sender;



            //    if (cards.Count() == 2)
            //    {
            //        foreach (Kartya kartya in cards)
            //        {

            //            kartya.timer.Start();


            //        }

            //        nem_talalt++;

            //    }
            //    cards.Add(k);

            //    if (cards.Count() != 2)
            //    {
            //        return;
            //    }

            //    int cardNum = cards.Get().kartyaSzam;
            //    foreach (Kartya card in cards)
            //    {
            //        if (cardNum != card.kartyaSzam)
            //        {
            //            return;
            //        }
            //    }
            //    cards.Clear();
            //    talalt++;
            //    label4.Text = talalt.ToString();
            //    if (talalt == nehezseg)
            //    {
            //        timer1.Stop();
            //        label7.Text = "Sosz gec";
            //        pictureBox1.Visible = true;
            //    }


            if (sender is Kartya)
            {
                Kartya k = (Kartya)sender;



                // nem ugyanaz a kártya, mint az el?z?
                if (elsoKartya != null && k == elsoKartya)
                    return;
                if (elsoKartya == null)
                {
                    elsoKartya = k;
                }
                else if (masodikKartya == null)
                {
                    masodikKartya = k;

                    // Ellen?rizzük, hogy a két kártya azonos
                    if (elsoKartya.kartyaSzam == masodikKartya.kartyaSzam)
                    {
                        elsoKartya.Visible = false;
                        masodikKartya.Visible = false;
                        elsoKartya = null;
                        masodikKartya = null;
                        talalt++;
                        label3.Text = talalt.ToString();
                        if (talalt == nehezseg)
                        {
                            timer1.Stop();
                            label6.Text = "Gratulálok, megtaláltad az összes párt!";
                            pictureBox1.Visible = true;
                        }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label5.Text = seconds.ToString();
        }
        int[] Keveres(int kartyaSzam)
        {
            //int[] tomb = new int[kartyaSzam];
            //for (int i = 0; i < kartyaSzam / 2; i++)
            //{

            //    tomb[i] = i + 1;
            //    tomb[i + kartyaSzam / 2] = i + 1;
            //}
            HashSet<int> szamok = new HashSet<int>();
            Random random = new Random();
            while (szamok.Count < 50)
            {
                int number = random.Next(1,51);
                szamok.Add(number);
            }
            int[] tomb1 = new int[51];

            int s = 0;
            foreach (int i in szamok)
            {
               
                tomb1[s] =i;
                s++;
            }
            int[] tomb = new int[kartyaSzam];
            for (int i = 0; i < kartyaSzam / 2; i++)
            {

                tomb[i] = tomb1[i];
                tomb[i + kartyaSzam / 2] = tomb1[i];
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
        private void button2_Click(object sender, EventArgs e)
        {
            int sorszam = 0;

            int[] t = Keveres(16);
            nehezseg = 8;


            label7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            timer1.Start();

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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sorszam = 0;

            int[] t = Keveres(8);
            nehezseg = 4;
            label7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            timer1.Start();

            for (int s = 0; s < 2; s++)
            {
                for (int o = 0; o < 4; o++)
                {
                    Kartya k = new Kartya(s, o, t[sorszam]);
                    Controls.Add(k);
                    k.Left = Width / 2 - ((2 - o) * Properties.Settings.Default.kepMeret + (2 - o) * Properties.Settings.Default.kepTavolsag);
                    k.Top = Height / 2 - ((1 - s) * Properties.Settings.Default.kepMeret + (1 - s) * Properties.Settings.Default.kepTavolsag);
                    k.Click += K_Click;

                    sorszam++;
                }
            }           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sorszam = 0;

            int[] t = Keveres(20);
            nehezseg = 10;

            label7.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            timer1.Start();

            for (int s = 0; s < 5; s++)
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
        }
    }
}



