using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_PZ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textBox2.Text);
            double x = Convert.ToDouble(textBox1.Text);
            double F;
            double i = 0;
            if (radioButton1.Checked)
            {
                i = 1;
            }
            else if (radioButton2.Checked)
            {
                i = 2;
            }
            else if (radioButton3.Checked)
            {
                i = 3;
            }
            switch (i)
            {
                case 1:
                    if (x - y == 0)
                    {
                        F = Math.Round(Math.Sin(Math.Sin(x)) + Math.Cos(Math.Sin(y)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' равна нулю" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if ( x - y > 0)
                    {
                        F = Math.Round(Math.Tan(Math.Sin(x + y)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' больше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if (x - y < 0)
                    {
                        F = Math.Round(Math.Pow(Math.Sin(Math.Sin(x)), 2) + Math.Pow(Math.Cos(Math.Sin(y)), 2), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' меньше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    break;
                case 2:
                    if (x - y == 0)
                    {
                        F = Math.Round(Math.Sin(Math.Pow(x, 2)) + Math.Cos(Math.Pow(y, 2)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' равна нулю" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if (x - y > 0)
                    {
                        F = Math.Round(Math.Tan(Math.Pow(x, 2) + Math.Pow(y, 2)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' больше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if (x - y < 0)
                    {
                        F = Math.Round(Math.Pow(Math.Sin(Math.Pow(x, 2)), 2) + Math.Pow(Math.Cos(Math.Pow(y, 2)), 2), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' меньше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    break;
                case 3:
                    if (x - y == 0)
                    {
                        F = Math.Round(Math.Sin(Math.Pow(Math.E, x)) + Math.Cos(Math.Pow(Math.E, y)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' равна нулю" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if (x - y > 0)
                    {
                        F = Math.Round(Math.Tan(Math.Pow(Math.E, x) + Math.Pow(Math.E, y)), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' больше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    else if (x - y < 0)
                    {
                        F = Math.Round(Math.Pow(Math.Sin(Math.Pow(Math.E, x)), 2) + Math.Pow(Math.Cos(Math.Pow(Math.E, y)), 2), 3);
                        textBox3.Text += "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine +
                            "Разность 'x - y' меньше нуля" + Environment.NewLine + "Ответ: " + F;
                    }
                    break;
            }
        }
    }
}
