using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point pole;
        private Point center;
        private Pen pen = new Pen(Color.Red, 3);
        private float diameter = 30f;
        private float a = 20;
        private float phi;


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
           
            center = new Point();
            center.X = (int)((a / (Math.PI * 2)) * phi * Math.Cos(phi));
            center.Y = (int)((a / (Math.PI * 2)) * phi * Math.Sin(phi));
            phi++;
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pole = new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(pole.X, pole.Y);
            g.DrawEllipse(pen, center.X, center.Y, diameter, diameter);

            center.Offset(pole);

            if (!ClientRectangle.Contains(center))
                phi = 0;
        }
    }
    
}
