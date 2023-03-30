using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_PZ7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 8;
            int[,] a = new int[n, n];
            a.Initialize();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            Random rand = new Random();
            Point[] points = new Point[8] { new Point(-2, -1), new Point(-1, -2), new Point(2, -1), new Point(-1, 2), new Point(2, 1), new Point(1, 2), new Point(-2, 1), new Point(1, -2) };
            List<Point> li_possible = new List<Point>();
            Point tek_point = new Point(rand.Next(n), rand.Next(n));
            a[tek_point.X, tek_point.Y] = 1;
            for (int i = 2; i < 65; i++)
            {
                li_possible.Clear();
                for (int j = 0; j < 8; j++)
                {
                    if (((tek_point.X + points[j].X) < n) &&
                    ((tek_point.X + points[j].X) > -1) &&
                        ((tek_point.Y + points[j].Y) < n) &&
                    ((tek_point.Y + points[j].Y) > -1) &&
                        (a[tek_point.X + points[j].X, tek_point.Y + points[j].Y] == 0)
                        )

                    {
                        li_possible.Add(new Point(tek_point.X + points[j].X, tek_point.Y + points[j].Y));
                    }
                }
                if (li_possible.Count > 0)
                {
                    tek_point = li_possible[rand.Next(li_possible.Count)];
                    a[tek_point.X, tek_point.Y] = i;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];

                }

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

        }
    }
}
