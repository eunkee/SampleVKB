using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleVKB
{
    public partial class Form1 : Form
    {
        private static Control focusedControl;

        //키보드들
        private readonly FormNumber formNumber = new();
        private readonly FormNumber2 formNumber2 = new();
        private readonly FormSimpleKeyboard ucVKBe = new();

        public Form1()
        {
            InitializeComponent();
        }

        //키보드
        public static void SetFocusedControl(string text)
        {
            focusedControl.Focus();
            SendKeys.Send(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CloseVKNumber();
        }

        public void CloseVKNumber(Control exceptionForm = null)
        {
            if(exceptionForm != formNumber)
            {
                formNumber.Visible = false;
            }
            if (exceptionForm != formNumber2)
            {
                formNumber2.Visible = false;
            }
            if (exceptionForm != ucVKBe)
            {
                ucVKBe.Visible = false;
            }
        }

        //textboxes
        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(radioFormNumber.Checked)
            {
                CloseVKNumber(formNumber);
                ViewKeyboard(sender, formNumber);
            }
            else if(radioFormNumber2.Checked)
            {
                CloseVKNumber(formNumber2);
                ViewKeyboard(sender, formNumber2);
            }
            else if(radioKeyboard.Checked)
            {
                CloseVKNumber(ucVKBe);
                ViewKeyboard(sender, ucVKBe);
            }
        }

        //Form VKNumber
        public void ViewKeyboard(object sender, Control form)
        {
            focusedControl = (Control)sender;
            int X = this.Location.X + this.Width;
            int Y = this.Location.Y;
            form.Visible = true;
            form.Location = new Point(X, Y);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            int X = this.Location.X + this.Width;
            int Y = this.Location.Y;

            if (formNumber.Visible)
            {
                formNumber.Location = new Point(X, Y);
            }
            if (formNumber2.Visible)
            {
                formNumber2.Location = new Point(X, Y);
            }
            if (ucVKBe.Visible)
            {
                ucVKBe.Location = new Point(X, Y);
            }
        }
    }
}
