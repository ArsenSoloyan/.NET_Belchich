using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_pz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            BackColor = Color.White;
            MessageBox.Show("МИНА!!!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = ("2 мины");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            BackColor = Color.White;
            MessageBox.Show("МИНА!!!");
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = ("1 мина");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = ("2 мины");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = ("2 мины");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = ("1 мина");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = ("2 мины");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            BackColor = Color.White;
            MessageBox.Show("МИНА!!!");
            Application.Exit();
        }
    }
}
