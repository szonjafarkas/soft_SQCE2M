namespace Memoria
{
    public partial class Form1 : Form
    {
        Kartya elozoKartya;
        Kartya elsoKartya = null;
        Kartya masodikKartya = null;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.hatterkep);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

            int sorszam = 0;

            int[] t = Keveres(16);

            for (int s = 0; s < 4; s++)
            {
                for (int o = 0; o < 4; o++)
                {
                    Kartya k = new Kartya(s, o, t[sorszam]);
                    Controls.Add(k);
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
                else if (masodikKartya == null )
                {
                    masodikKartya = k;
                    masodikKartya.Felfordit();
                   


                    // Ellenõrizzük, hogy a két kártya azonos
                    if (elsoKartya.kartyaSzam == masodikKartya.kartyaSzam)
                    {
                        elsoKartya.Visible = false;
                        masodikKartya.Visible = false;
                        elsoKartya = null;
                        masodikKartya = null;

                    }
                    else
                    {
                        

                        elsoKartya.Lefordit();
                        masodikKartya.Lefordit();
                        elsoKartya = null;
                        masodikKartya = null;
                    }
                    
                }
                


            }


        }
    }
}

    

