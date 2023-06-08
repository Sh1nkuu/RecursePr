using System.Drawing;
using System.Windows.Forms;

namespace RecurseMet
{
    public partial class Form1 : System.Windows.Forms.Form

    {


        public int x; public double k = 0.4;
        public Form1()
        {
            InitializeComponent();
        }

        private void MyDraw(Graphics g, int N, int R)
        {
            if (N == 0) return;

            g.DrawEllipse(new Pen(Brushes.Blue, 2), x, x, R, R);
            x = x + (int)(R * k);
            R += 30;

            N--;

            MyDraw(g, N, R);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int R = 20;
            x = x + (int)(k * R);
            MyDraw(g, 7, R);
        }
    }
}

