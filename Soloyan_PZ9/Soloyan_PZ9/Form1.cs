using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_PZ9
{
    public partial class Form1 : Form
    {
        SolidBrush pesok = new SolidBrush(Color.Gold);
        SolidBrush lyst = new SolidBrush(Color.Green);
        SolidBrush korabl = new SolidBrush(Color.Brown);
        SolidBrush kauta = new SolidBrush(Color.Chocolate);
        SolidBrush element = new SolidBrush(Color.SaddleBrown);
        SolidBrush sun = new SolidBrush(Color.Orange);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // небо
            Graphics g = e.Graphics;
            g.Clear(Color.Aqua);

            //солнце
            g.FillEllipse(sun, 350, 150, 266, 237);

            // море
            g.FillRectangle(pesok, 0, 250, 1000, 1000);

            //Пальма.1
            g.FillRectangle(element, 100, 160, 25, 100);  
            
            //Лист.П1(1)
            Point point5 = new Point(110, 160);
            Point point6 = new Point(35, 176);
            Point point7 = new Point(94, 149);
            Point point11 = new Point(120, 159);
            Point[] Lyst =
            {
                point5, point6, point7, point11
            };
            g.FillPolygon(lyst, Lyst);

            //Лист.П1(2)
            Point point8 = new Point(126, 160);
            Point point9 = new Point(190, 173);
            Point point10 = new Point(140, 146);
            Point point12 = new Point(110, 160);
            Point[] Lyst2 =
            {
                point8, point9, point10, point12
            };
            g.FillPolygon(lyst, Lyst2);

            //Лист.П1(3)
            Point point13 = new Point(100, 160);
            Point point14 = new Point(77, 179);
            Point point15 = new Point(106, 173);
            Point point16 = new Point(116, 160);
            Point[] Lyst3 =
            {
                point13, point14, point15, point16
            };
            g.FillPolygon(lyst, Lyst3);

            //Лист.П1(4)
            Point point17 = new Point(122, 160);
            Point point18 = new Point(158, 179);
            Point point19 = new Point(120, 173);
            Point point20 = new Point(116, 160);
            Point[] Lyst4 =
            {
                point17, point18, point19, point20
            };
            g.FillPolygon(lyst, Lyst4);
            
            //Кокосы.П1
            g.FillEllipse(kauta, 90, 160, 19, 15);
            g.FillEllipse(kauta, 115, 160, 19, 15);

            //Шизлонг
            g.FillRectangle(element, 670, 235, 3, 21);
            g.FillRectangle(element, 670, 235,89, 11);
            g.FillRectangle(element, 756, 235, 3, 21);
            Point point21 = new Point(756, 240);
            Point point22 = new Point(780, 190);
            Point point23 = new Point(756, 230);
            Point point24 = new Point(756, 250);
            Point[] Shizh =
            {
                point21, point22, point23, point24
            };
            g.FillPolygon(element, Shizh);

            //Пальма.2
            g.FillRectangle(element, 800, 160, 25, 100);

            //Лист.П2(1)
            Point point25 = new Point(810, 160);
            Point point26 = new Point(735, 176);
            Point point27 = new Point(794, 149);
            Point point28 = new Point(820, 159);
            Point[] Lyst5 =
            {
                point25, point26, point27, point28
            };
            g.FillPolygon(lyst, Lyst5);

            //Лист.П2(2)
            Point point29 = new Point(826, 160);
            Point point30 = new Point(890, 173);
            Point point31 = new Point(840, 146);
            Point point32 = new Point(810, 160);
            Point[] Lyst6 =
            {
                point29, point30, point31, point32
            };
            g.FillPolygon(lyst, Lyst6);
            
            //Лист.П2(3)
            Point point33 = new Point(800, 160);
            Point point34 = new Point(777, 179);
            Point point35 = new Point(806, 173);
            Point point36 = new Point(816, 160);
            Point[] Lyst7 =
            {
                point33, point34, point35, point36
            };
            g.FillPolygon(lyst, Lyst7);

            //Лист.П2(4)
            Point point37 = new Point(822, 160);
            Point point38 = new Point(858, 179);
            Point point39 = new Point(820, 173);
            Point point40 = new Point(816, 160);
            Point[] Lyst8 =
            {
                point37, point38, point39, point40
            };
            g.FillPolygon(lyst, Lyst8);

            //Кокосы.П2
            g.FillEllipse(kauta,790, 160, 19, 15);
            g.FillEllipse(kauta, 815, 160, 19, 15);

        }
    }
}
