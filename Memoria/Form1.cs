namespace Memoria
{
    public partial class Form1 : Form
    {
        Kartya elozoKartya;
        
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

            int[] t = Keveres(12);

            for (int s = 0; s < 4; s++)
            {
                for (int o = 0; o < 3; o++)
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
                for (int i = 0;i < kartyaSzam / 2; i++)
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
                if (elozoKartya != null)
                {
                    if (k.kartyaSzam == elozoKartya.kartyaSzam && k != elozoKartya)
                    {
                        k.Visible = false;
                        elozoKartya.Visible = false;
                    }

                }
                elozoKartya = k;
            }
        }
            
    }
}
