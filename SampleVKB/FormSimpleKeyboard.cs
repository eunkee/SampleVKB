using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleVKB
{
    public partial class FormSimpleKeyboard : Form
    {
        bool _shitlock = false;

        public FormSimpleKeyboard()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ButtonShift_Click(object sender, EventArgs e)
        {
            if(!_shitlock)
            {
                _shitlock = true;

                btnDot.Text = ".";
                btn0.Text = ")";
                btn1.Text = "!";
                btn2.Text = "@";
                btn3.Text = "#";
                btn4.Text = "$";
                btn5.Text = "%";
                btn6.Text = "^";
                btn7.Text = "&&";
                btn8.Text = "*";
                btn9.Text = "(";

                button_q.Text = "Q";
                button_w.Text = "W";
                button_e.Text = "E";
                button_r.Text = "R";
                button_t.Text = "T";
                button_y.Text = "Y";
                button_u.Text = "U";
                button_i.Text = "I";
                button_o.Text = "O";
                button_p.Text = "P";

                button_a.Text = "A";
                button_s.Text = "S";
                button_d.Text = "D";
                button_f.Text = "F";
                button_g.Text = "G";
                button_h.Text = "H";
                button_j.Text = "J";
                button_k.Text = "K";
                button_l.Text = "L";

                button_z.Text = "Z";
                button_x.Text = "X";
                button_c.Text = "C";
                button_v.Text = "V";
                button_b.Text = "B";
                button_n.Text = "N";
                button_m.Text = "M";

                button_question.Text = "/";
                button_dot2.Text = "_";
                btnDot.Text = ":";
                button_comma.Text = ";";
                button_quotes.Text = "\"";
            }
            else
            {
                _shitlock = false; 

                btnDot.Text = ".";

                btn0.Text = "0";
                btn1.Text = "1";
                btn2.Text = "2";
                btn3.Text = "3";
                btn4.Text = "4";
                btn5.Text = "5";
                btn6.Text = "6";
                btn7.Text = "7";
                btn8.Text = "8";
                btn9.Text = "9";

                button_q.Text = "q";
                button_w.Text = "w";
                button_e.Text = "e";
                button_r.Text = "r";
                button_t.Text = "t";
                button_y.Text = "y";
                button_u.Text = "u";
                button_i.Text = "i";
                button_o.Text = "o";
                button_p.Text = "p";

                button_a.Text = "a";
                button_s.Text = "s";
                button_d.Text = "d";
                button_f.Text = "f";
                button_g.Text = "g";
                button_h.Text = "h";
                button_j.Text = "j";
                button_k.Text = "k";
                button_l.Text = "l";

                button_z.Text = "z";
                button_x.Text = "x";
                button_c.Text = "c";
                button_v.Text = "v";
                button_b.Text = "b";
                button_n.Text = "n";
                button_m.Text = "m";

                button_question.Text = "?";
                btnDot.Text = ".";
                button_dot2.Text = "-";
                button_comma.Text = ",";
                button_quotes.Text = "\'";
            }
        }

        private void Button_q_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_q.Text);
        }

        private void Button_w_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_w.Text);
        }

        private void Button_e_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_e.Text);
        }

        private void Button_r_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_r.Text);
        }

        private void Button_t_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_t.Text);
        }

        private void Button_y_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_v.Text);
        }

        private void Button_u_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_u.Text);
        }

        private void Button_i_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_i.Text);
        }

        private void Button_o_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_o.Text);
        }

        private void Button_p_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_p.Text);
        }

        private void Button_a_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_a.Text);
        }

        private void Button_s_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_s.Text);
        }

        private void Button_d_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_d.Text);
        }

        private void Button_f_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_f.Text);
        }

        private void Button_g_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_g.Text);
        }

        private void Button_h_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_h.Text);
        }

        private void Button_j_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_j.Text);
        }

        private void Button_k_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_k.Text);
        }

        private void Button_l_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_l.Text);
        }

        private void Button_quotes_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_quotes.Text);
        }

        private void Button_z_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_z.Text);
        }

        private void Button_x_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_x.Text);
        }

        private void Button_c_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_c.Text);
        }

        private void Button_v_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_v.Text);
        }

        private void Button_b_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_b.Text);
        }

        private void Button_n_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_n.Text);
        }

        private void Button_m_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_m.Text);
        }

        private void Button_comma_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_comma.Text);
        }

        private void Button_dot2_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_dot2.Text);
        }

        private void Button_question_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(button_question.Text);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                SendKeys.Send("1");
                Form1.SetFocusedControl("1");
            }
            else
            {
                Form1.SetFocusedControl("!");
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("2");
            }
            else
            {
                Form1.SetFocusedControl("@");
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("3");
            }
            else
            {
                Form1.SetFocusedControl("#");
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("4");
            }
            else
            {
                Form1.SetFocusedControl("$");
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("5");
            }
            else
            {
                Form1.SetFocusedControl("{%}");
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("6");
            }
            else
            {
                Form1.SetFocusedControl("{^}");
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("7");
            }
            else
            {
                Form1.SetFocusedControl("&");
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("8");
            }
            else
            {
                Form1.SetFocusedControl("*");
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("9");
            }
            else
            {
                Form1.SetFocusedControl("{(}");
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (!_shitlock)
            {
                Form1.SetFocusedControl("0");
            }
            else
            {
                Form1.SetFocusedControl("{)}");
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(btnDot.Text);
        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("{BS}");
        }

        private void Button_space_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl(" ");
        }

        private void Button_left_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("{LEFT}");
        }

        private void Button_right_Click(object sender, EventArgs e)
        {
            Form1.SetFocusedControl("{RIGHT}");
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
