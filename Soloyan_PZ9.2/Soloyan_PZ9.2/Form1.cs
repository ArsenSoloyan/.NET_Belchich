using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Soloyan_PZ9._2
{
    public partial class Form1 : Form
    {
        GraphicsPath siuuuu;
        public Form1()
        {
            InitializeComponent();
            siuuuu = new GraphicsPath();
        }

        bool xORy = true;
        string way = "centre-left";

        HatchStyle hbrh;
        Color folor;
        public float dirx, diry, xpos, ypos, oiub = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            folor = Color.Yellow;
            hbrh = HatchStyle.DarkVertical;
            xpos = 300;
            ypos = 130;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (way)
            {
                case "centre-left":
                    if (xpos > 50)
                    {
                        if (xORy != false)
                        {
                            xpos -= 5;
                            ypos -= 0;
                        }
                    }
                    else
                        way = "left-centre";
                    break;
                case "left-centre":
                    if (xpos < 300)
                    {
                        if (xORy != false)
                        {
                            xpos += 5;
                            ypos += 0;
                        }
                    }
                    else
                        way = "centre-up";
                    if (xpos > 299) 
                    {
                        xORy = false;
                    }
                    break;
                case "centre-up":
                    if (ypos > 50)
                    {
                        if (xORy != true)
                        {
                            xpos += 0;
                            ypos -= 2;
                        }
                    }
                    else
                        way = "up-centre";
                    break;
                case "up-centre":
                    if (ypos < 130)
                    {
                        if (xORy != true)
                        {
                            xpos -= 0;
                            ypos += 2;
                        }
                    }
                    else
                        way = "centre-right";
                    break;
                 case "centre-right":
                    if (xpos <= 550)
                    {
                        if (xORy != true)
                        {
                            xpos += 5;
                            ypos += 0;
                        }
                    }
                    else
                        way = "right-centre";
                    break;
                case "right-centre":
                    if (xpos > 300)
                    {
                        if (xORy != true)
                        {
                            xpos -= 5;
                            ypos += 0;
                        }
                    }
                    else way = "centre-down";
                    break;
                case "centre-down":
                    if (ypos < 260)
                    {
                        if (xORy != true)
                        {
                            xpos += 0;
                            ypos += 2;
                        }
                    }
                    else
                        way = "down-centre";
                    break;
                case "down-centre":
                    if (ypos > 130)
                    {
                        if (xORy != true)
                        {
                            xpos += 0;
                            ypos -= 2;
                        }
                    }
                    else
                    {
                        xORy = true;
                        way = "centre-left";
                    }
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            HatchBrush brush = new HatchBrush(hbrh, folor);

            Pen pen1 = new Pen(Color.White, 0);
            g.DrawRectangle(pen1, xpos -40, ypos - 20, 110, 110);

            RectangleF rect = new RectangleF(xpos + 5, ypos, 36, 60);
            g.FillRectangle(brush, rect);
            RectangleF rect2 = new RectangleF(xpos - 39, ypos + 50, 80, 30);
            g.FillRectangle(brush, rect2);

            PointF p1 = new PointF(xpos - 23, ypos + 20);
            PointF p2 = new PointF(xpos + 23, ypos - 20);
            PointF p3 = new PointF(xpos + 70, ypos + 20);
            PointF[] tr = { p1, p2, p3 };
            g.FillPolygon(brush, tr);

            PointF p4 = new PointF(xpos - 39, ypos + 30);
            PointF p5 = new PointF(xpos - 39, ypos + 100);
            PointF p6 = new PointF(xpos - 85, ypos + 60);
            PointF[] tr2 = { p4, p5, p6 };
            g.FillPolygon(brush, tr2);

            siuuuu.Reset();
            siuuuu.StartFigure();
            siuuuu.AddEllipse(rect);
            siuuuu.CloseFigure();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                if (siuuuu.IsVisible(pt))
                {
                    ColorDialog clrDlg = new ColorDialog();
                    if (clrDlg.ShowDialog() == DialogResult.OK)
                        folor = clrDlg.Color;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                if (siuuuu.IsVisible(pt))
                {
                    Form2 styleDialog = new Form2();
                    if (styleDialog.ShowDialog() == DialogResult.OK)
                        hbrh = styleDialog.Style;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 101 - trackBar1.Value;
        }
    }
}

