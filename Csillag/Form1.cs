using Csillag.Models;

namespace Csillag
{
    public partial class Form1 : Form


    {

        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            

            Color c = Color.White;
            Color c2 = Color.Red;
            Pen pen = new Pen(c2, 1);
            Brush brush = new SolidBrush(c);

            hajosContext context = new hajosContext();
            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();
            double nagyitas = 300;
            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;

            g.Clear(Color.DarkBlue);

            foreach (var star in stars)
            {
                if (star.Magnitude > 6) continue;
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;
                float x = (float)(star.X * nagyitas + cx);
                float y = (float)(star.Y * nagyitas + cy);
                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {
                var star1 = (from x in stars where x.Hip == line.Star1 select x).FirstOrDefault();
                var star2 = (from x in stars where x.Hip == line.Star2 select x).FirstOrDefault();

                if (star1 != null || star2 != null) continue;

                float x1 = (float)(star1.X * nagyitas + cx);
                float y1 = (float)(star2.Y * nagyitas + cy);
                float x2 = (float)(star1.X * nagyitas + cx);
                float y2 = (float)(star2.Y * nagyitas + cy);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
            
        }
    }
}