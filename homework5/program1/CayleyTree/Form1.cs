using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double th = double .Parse(textBox2.Text);
            
            if (graphics == null)
            { graphics = this.CreateGraphics();
              drawCayleyTree(10, 300, 350, 70, th);
            }
            else
                {
               
                graphics = this.CreateGraphics();
                drawCayleyTree(10, 300, 350, 70, th);

            }
            
          
            
           
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;

        void drawCayleyTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double per1 = double.Parse(textBox3.Text);
            double per2 = double.Parse(textBox4.Text);
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + 1.2*leng * Math.Cos(th);
            double y2 = y0 + 1.2 * leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * 1.2*leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
          
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
