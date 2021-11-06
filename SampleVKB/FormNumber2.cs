using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleVKB
{
    public partial class FormNumber2 : Form
    {
        public FormNumber2()
        {
            InitializeComponent();
            BindControlMouseClicks(this);
        }

        #region 배경 클릭 이동

        //폼에 속한 컨트롤 클릭시 배경 이동으로 포함
        public delegate void GlobalMouseClickEventHander(object sender, MouseEventArgs e);

        private void BindControlMouseClicks(Control con)
        {
            if (con != this)
            {
                con.MouseDown += delegate (object sender, MouseEventArgs e)
                {
                    TriggerMouseDowned(sender, e);
                };
                con.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    TriggerMouseMoved(sender, e);
                };
            }
            foreach (Control i in con.Controls)
            {
                //배경에 속하지 않는 컨트롤
                if ((i != Button1) && (i != Button2) && (i != Button3) && (i != Button4)
                    && (i != Button5) && (i != Button6) && (i != Button7) && (i != Button8) && (i != Button9)
                    && (i != Button0) && (i != ButtonBS) && (i != ButtonOK) && (i != ButtonClose))
                {
                    BindControlMouseClicks(i);
                }
            }
            con.ControlAdded += delegate (object sender, ControlEventArgs e)
            {
                BindControlMouseClicks(e.Control);
            };
        }

        private void TriggerMouseDowned(object sender, MouseEventArgs e)
        {
            FormVKB2_MouseDown(sender, e);
        }

        private void TriggerMouseMoved(object sender, MouseEventArgs e)
        {
            FormVKB2_MouseMove(sender, e);
        }

        //폼 배경클릭 이동
        private Point mousePoint;

        private void FormVKB2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FormVKB2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        #endregion 배경 클릭 이동

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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}