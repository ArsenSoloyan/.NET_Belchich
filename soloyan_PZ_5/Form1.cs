using Microsoft.VisualBasic.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace soloyan_PZ_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;
        int h = 10;

        private void button1_Click(object sender, EventArgs e)
        {
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
                    Random rand = new Random();
                    TextBox b = new TextBox();
                    b.Parent = this;
                    b.Size = new Size(50, 20);
                    int x1 = rand.Next(n, n);

                    b.Location = new Point(x1, h);
                    n = n + 50;
                    if (n == 800)
                    {
                        n = n * 0;
                        h = h + 20;
                    }

                    break;
                case 2:
                    Random r = new Random();
                    Button z = new Button();
                    z.Parent = this;
                    z.Size = new Size(50, 20);
                    int x2 = r.Next(n, n);

                    z.Location = new Point(x2, h);
                    n = n + 50;
                    if (n == 800)
                    {
                        n = n * 0;
                        h = h + 20;
                    }
                    break;
                case 3:
                    Random R = new Random();
                    Label l = new Label();
                    l.Parent = this;
                    l.Size = new Size(50, 20);
                    int x3 = R.Next(n, n);

                    l.Location = new Point(x3, h);
                    n = n + 50;
                    l.Text = "Label";
                    if (n == 800)
                    {
                        n = n * 0;
                        h = h + 20;
                    }
                    break;
            }
        }
    }
}