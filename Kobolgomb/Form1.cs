namespace Kobolgomb
{
    public partial class Form1 : Form
    {
        int meret = 40;
        int meret2 = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            

            for (int sor=0; sor < 10; sor++)
            {
                for(int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzámolóGomb sz = new SzámolóGomb();
                    sz.Height = meret2;
                    sz.Width = meret2;
                    sz.Left = oszlop * meret2;
                    sz.Top = sor * meret2;
                    Controls.Add(sz);
                }
            }
            

            
            
        }
    }
}