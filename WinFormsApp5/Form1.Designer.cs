namespace WinFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            C = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 144);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HighlightText;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("华文宋体", 27.9999962F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-245, 0);
            label1.Name = "label1";
            label1.Size = new Size(917, 144);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(C);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button16);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 667);
            panel2.TabIndex = 1;
            // 
            // C
            // 
            C.ForeColor = Color.Red;
            C.Location = new Point(26, 3);
            C.Name = "C";
            C.Size = new Size(291, 89);
            C.TabIndex = 16;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += ClearButton_Click;
            // 
            // button13
            // 
            button13.Location = new Point(517, 526);
            button13.Name = "button13";
            button13.Size = new Size(132, 97);
            button13.TabIndex = 15;
            button13.Text = "÷";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OperatorButton_Click;
            // 
            // button14
            // 
            button14.Location = new Point(354, 526);
            button14.Name = "button14";
            button14.Size = new Size(132, 97);
            button14.TabIndex = 14;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = true;
            button14.Click += EqualsButton_Click;
            // 
            // button15
            // 
            button15.Location = new Point(185, 526);
            button15.Name = "button15";
            button15.Size = new Size(132, 97);
            button15.TabIndex = 13;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(26, 526);
            button16.Name = "button16";
            button16.Size = new Size(132, 97);
            button16.TabIndex = 12;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(517, 387);
            button9.Name = "button9";
            button9.Size = new Size(132, 97);
            button9.TabIndex = 11;
            button9.Text = "×";
            button9.UseVisualStyleBackColor = true;
            button9.Click += OperatorButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(354, 387);
            button10.Name = "button10";
            button10.Size = new Size(132, 97);
            button10.TabIndex = 10;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(185, 387);
            button11.Name = "button11";
            button11.Size = new Size(132, 97);
            button11.TabIndex = 9;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(26, 387);
            button12.Name = "button12";
            button12.Size = new Size(132, 97);
            button12.TabIndex = 8;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(517, 238);
            button5.Name = "button5";
            button5.Size = new Size(132, 97);
            button5.TabIndex = 7;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OperatorButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(354, 238);
            button6.Name = "button6";
            button6.Size = new Size(132, 97);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(185, 238);
            button7.Name = "button7";
            button7.Size = new Size(132, 97);
            button7.TabIndex = 5;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(26, 238);
            button8.Name = "button8";
            button8.Size = new Size(132, 97);
            button8.TabIndex = 4;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(517, 101);
            button4.Name = "button4";
            button4.Size = new Size(132, 97);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OperatorButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(354, 101);
            button3.Name = "button3";
            button3.Size = new Size(132, 97);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 98);
            button2.Name = "button2";
            button2.Size = new Size(132, 97);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 101);
            button1.Name = "button1";
            button1.Size = new Size(132, 97);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 811);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button C;
    }
}
