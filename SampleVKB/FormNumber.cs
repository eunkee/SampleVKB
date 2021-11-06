using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleVKB
{
    public partial class FormNumber : Form
    {
        public FormNumber()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("0");
        }

        private void ButtonBS_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("{BS}");
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(".");
        }

        private void FormVKB2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
