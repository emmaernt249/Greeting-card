using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Green, 10);
            SolidBrush ddrawBrush = new SolidBrush(Color.Red);
            SolidBrush dddrawBrush = new SolidBrush(Color.Green);
            SolidBrush ddddrawBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);
            g.DrawString("Click the present!", drawFont, drawBrush, 50, 40);

            
            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);

            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);
            g.DrawString("Click the present!", drawFont, drawBrush, 50, 40);


            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);


            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);
            g.DrawString("Click the present!", drawFont, drawBrush, 50, 40);


            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);

            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);
            g.DrawString("Click the present!", drawFont, drawBrush, 50, 40);


            Thread.Sleep(1000);
            g.Clear(Color.LightPink);
            g.FillRectangle(ddrawBrush, 300, 200, 200, 200);
            g.FillRectangle(dddrawBrush, 370, 200, 20, 200);
            g.FillRectangle(dddrawBrush, 300, 300, 200, 20);
            g.FillEllipse(dddrawBrush, 300, 170, 100, 50);
            g.FillEllipse(dddrawBrush, 370, 170, 100, 50);
            g.FillEllipse(ddddrawBrush, 365, 180, 40, 40);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush ddrawBrush = new SolidBrush(Color.Red);
            SolidBrush drawBrush = new SolidBrush(Color.Green);
            g.Clear(Color.LightPink);
            g.DrawString("Have a merry christmas!", drawFont, ddrawBrush, 50, 40);
            g.FillPie(drawBrush, 20, 0, 1000, 200, 69, 45);
            g.FillPie(drawBrush, 20, 10, 1000, 300, 69, 45);
            g.FillPie(drawBrush, 20, 100, 1000, 300, 69, 45);
        }
    }
}
