using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_7
{
    public partial class Form1 : Form
    {
        // TreeArgs
        private Graphics graphics;
        int Depth = 10;
        int Length = 100;
        double th1 = 30;
        double th2 = 20;
        double per1 = 0.6;
        double per2 = 0.7;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            graphics.Clear(new Color());

            int.TryParse(textBox1.Text, out Depth);
            int.TryParse(textBox2.Text, out Length);
            double.TryParse(textBox3.Text, out per1);
            double.TryParse(textBox4.Text, out per2);
            double.TryParse(textBox5.Text, out th1);
            double.TryParse(textBox6.Text, out th2);

            drawCayleyTree(Depth, 400, 500, Length, -Math.PI / 2);
        }
        
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(n, x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1 * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2 * Math.PI / 180);
        }
        

        void drawLine(int level, double x0, double y0, double x1, double y1)
        {
            int color = 55 + 200 / Depth * level;
            graphics.DrawLine(
                new Pen(Color.FromArgb(255,color,color,color),12), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void depth_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
