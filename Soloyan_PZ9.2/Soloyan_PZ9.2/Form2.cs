using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_PZ9._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public HatchStyle Style
        {
            get
            {
                if (radioButton1.Checked)
                    return HatchStyle.DiagonalCross;
                if (radioButton2.Checked)
                    return HatchStyle.DashedHorizontal;
                if (radioButton3.Checked)
                    return HatchStyle.Cross;
                if (radioButton4.Checked)
                    return HatchStyle.DarkVertical;
                if (radioButton5.Checked)
                    return HatchStyle.DashedDownwardDiagonal;
                return HatchStyle.DottedGrid;
            }
            set
            {
                if (value == HatchStyle.DashedDownwardDiagonal)
                    radioButton1.Checked = true;
                if (value == HatchStyle.DashedHorizontal)
                    radioButton2.Checked = true;
                if (value == HatchStyle.Cross)
                    radioButton3.Checked = true;
                if (value == HatchStyle.DarkVertical)
                    radioButton4.Checked = true;
                if (value == HatchStyle.DiagonalCross)
                    radioButton5.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked= false;
            radioButton5.Checked = false;
        }
    }
}
