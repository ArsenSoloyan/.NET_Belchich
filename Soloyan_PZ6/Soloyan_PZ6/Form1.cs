using System;
using System.Windows.Forms;

namespace Soloyan_PZ6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] M1 = new int[15];
        int[] M2 = new int[15];
        int[] M3 = new int[15];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i1 = 0; i1 < M1.Length; i1++)
            {
                M1[i1] = rand.Next(-50, 100);
                listBox1.Items.Add("M1[" + i1.ToString() +
                                      "] = " + M1[i1].ToString());
            }
            for (int i1 = 0; i1 < M2.Length; i1++)
            {
                M2[i1] = rand.Next(-50, 100);
                listBox2.Items.Add("M2[" + i1.ToString() +
                                      "] = " + M2[i1].ToString());
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for (int i1 = 0; i1 < M3.Length; i1++)
            {
                if (M1[i1] <= M2[i1])
                {
                    M3[i1] = M1[i1];
                }
                else
                {
                    M3[i1] = M2[i1];
                }
                listBox3.Items.Add("M2[" + i1.ToString() +
                                      "] = " + M3[i1].ToString());
            }
        }
    }
}

