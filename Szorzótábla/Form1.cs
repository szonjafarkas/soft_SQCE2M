namespace Szorzótábla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {


                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Button b = new Button();
                    b.Width = 40;
                    b.Height = 40;
                    b.Left = oszlop * 40;
                    b.Top = sor * 40;
                    b.Text =((sor + 1) * (oszlop+1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}