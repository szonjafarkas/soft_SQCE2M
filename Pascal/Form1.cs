namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    Button b = new Button();
                    Controls.Add(b);
                    b.Top = sor * n;
                    b.Left = oszlop * n;
                    b.Height = n;
                    b.Width = n;
                    int x = Faktori�lis(sor) / (Faktori�lis(oszlop) * Faktori�lis(sor - oszlop));
                    b.Text = x.ToString();
                }
            }

        }
        int Faktori�lis(int n)
        {
            if (n == 0) return 1;
            return n * Faktori�lis(n - 1);

        }
    }
}