
namespace SampleVKB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioFormNumber = new System.Windows.Forms.RadioButton();
            this.radioFormNumber2 = new System.Windows.Forms.RadioButton();
            this.radioKeyboard = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            // 
            // radioFormNumber
            // 
            this.radioFormNumber.AutoSize = true;
            this.radioFormNumber.Checked = true;
            this.radioFormNumber.Location = new System.Drawing.Point(27, 37);
            this.radioFormNumber.Name = "radioFormNumber";
            this.radioFormNumber.Size = new System.Drawing.Size(102, 19);
            this.radioFormNumber.TabIndex = 1;
            this.radioFormNumber.TabStop = true;
            this.radioFormNumber.Text = "number pad 1";
            this.radioFormNumber.UseVisualStyleBackColor = true;
            this.radioFormNumber.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioFormNumber2
            // 
            this.radioFormNumber2.AutoSize = true;
            this.radioFormNumber2.Location = new System.Drawing.Point(159, 37);
            this.radioFormNumber2.Name = "radioFormNumber2";
            this.radioFormNumber2.Size = new System.Drawing.Size(102, 19);
            this.radioFormNumber2.TabIndex = 2;
            this.radioFormNumber2.Text = "number pad 2";
            this.radioFormNumber2.UseVisualStyleBackColor = true;
            this.radioFormNumber2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioKeyboard
            // 
            this.radioKeyboard.AutoSize = true;
            this.radioKeyboard.Location = new System.Drawing.Point(285, 37);
            this.radioKeyboard.Name = "radioKeyboard";
            this.radioKeyboard.Size = new System.Drawing.Size(114, 19);
            this.radioKeyboard.TabIndex = 3;
            this.radioKeyboard.Text = "simple Keyboard";
            this.radioKeyboard.UseVisualStyleBackColor = true;
            this.radioKeyboard.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 185);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radioKeyboard);
            this.Controls.Add(this.radioFormNumber2);
            this.Controls.Add(this.radioFormNumber);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sample VKB";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioFormNumber;
        private System.Windows.Forms.RadioButton radioFormNumber2;
        private System.Windows.Forms.RadioButton radioKeyboard;
        private System.Windows.Forms.TextBox textBox2;
    }
}

