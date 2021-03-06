using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework07_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Graphics graphics;
        static double th1 = 30 * Math.PI / 180;
        static double th2 = 20 * Math.PI / 180;
        static double per1 = 0.6;
        static double per2 = 0.7;

        static int n=0;
        static double leng=0;
        Color col;
        
        void drawCayLeyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayLeyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
        private void create_btn_Click(object sender, EventArgs e)
            
        {
            getMessage();
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(BackColor);
            drawCayLeyTree(n,270,380,leng, -Math.PI / 2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(new Pen(Color.FromArgb(col.R,col.G,col.B)), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void getMessage()
        {
            n = Convert.ToInt32(NText.Text);
            leng = Convert.ToDouble(lengText.Text);
            per1 = Convert.ToDouble(per1Text.Text);
            per2 = Convert.ToDouble(per2Text.Text);
            th1 = Convert.ToDouble(th1Text.Text) * Math.PI / 180;
            th2 = Convert.ToDouble(th2Text.Text) * Math.PI / 180;
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                col = colorDialog1.Color;
                panel2.BackColor = col;
            }
        }
    }
}
