using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double x = Convert.ToDouble(textBox4.Text);
            double y;
            y = Math.Round(((a * x - Math.Sqrt(b)) / 5.7 * ((Math.Pow(x, 2) + Math.Pow(b, 2)))) -
                ((Math.Abs(x + b) - Math.Pow(a, 2)) / Math.Pow(x, 2)) * Math.Pow(Math.Tan(b), 2), 3);
            label4.Text = y.ToString();
        }
    }
}
