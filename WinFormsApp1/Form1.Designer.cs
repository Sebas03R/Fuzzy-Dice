namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            label11 = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button1 = new Button();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 73);
            label1.TabIndex = 0;
            label1.Text = "Fuzzy Dice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "Order Number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(155, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 1;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 1;
            label4.Text = "Address:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDark;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(100, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlDark;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(100, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlDark;
            textBox4.ForeColor = SystemColors.Window;
            textBox4.Location = new Point(100, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(275, 23);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlDark;
            textBox5.ForeColor = SystemColors.Window;
            textBox5.Location = new Point(100, 273);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(275, 23);
            textBox5.TabIndex = 2;
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 336);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 1;
            label5.Text = "Type:";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 362);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "White/Black";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 387);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Red/Black";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 412);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Blue/Black";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 336);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 1;
            label6.Text = "Quantity:";
            label6.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlDark;
            textBox6.ForeColor = SystemColors.Window;
            textBox6.Location = new Point(108, 360);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox1_TextChanged;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ControlDark;
            textBox7.ForeColor = SystemColors.Window;
            textBox7.Location = new Point(108, 385);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 2;
            textBox7.TextChanged += textBox2_TextChanged;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ControlDark;
            textBox8.ForeColor = SystemColors.Window;
            textBox8.Location = new Point(108, 410);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 2;
            textBox8.TextChanged += textBox3_TextChanged;
            textBox8.KeyPress += textBox8_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(213, 336);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 1;
            label7.Text = "Price:";
            label7.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(214, 360);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 1;
            label8.Text = "$6.25";
            label8.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(214, 387);
            label9.Name = "label9";
            label9.Size = new Size(45, 19);
            label9.TabIndex = 1;
            label9.Text = "$5.00";
            label9.Click += label5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(214, 412);
            label10.Name = "label10";
            label10.Size = new Size(45, 19);
            label10.TabIndex = 1;
            label10.Text = "$7.50";
            label10.Click += label5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(275, 358);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 21);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(275, 336);
            label11.Name = "label11";
            label11.Size = new Size(67, 23);
            label11.TabIndex = 1;
            label11.Text = "Totals:";
            label11.Click += label5_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(275, 383);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(100, 21);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(275, 410);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(100, 21);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox1_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(183, 454);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 1;
            label12.Text = "Subtotal:";
            label12.Click += label5_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(183, 480);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 1;
            label13.Text = "Tax:";
            label13.Click += label5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(186, 509);
            label14.Name = "label14";
            label14.Size = new Size(89, 23);
            label14.TabIndex = 1;
            label14.Text = "Shipping:";
            label14.Click += label5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(183, 536);
            label15.Name = "label15";
            label15.Size = new Size(92, 23);
            label15.TabIndex = 1;
            label15.Text = "Discount:";
            label15.Click += label5_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(183, 559);
            label16.Name = "label16";
            label16.Size = new Size(59, 23);
            label16.TabIndex = 1;
            label16.Text = "Total:";
            label16.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 474);
            button1.Name = "button1";
            button1.Size = new Size(137, 79);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(278, 457);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(97, 21);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(278, 483);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(100, 21);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            richTextBox5.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(278, 511);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(100, 21);
            richTextBox6.TabIndex = 4;
            richTextBox6.Text = "";
            richTextBox6.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(278, 538);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(100, 21);
            richTextBox7.TabIndex = 4;
            richTextBox7.Text = "";
            richTextBox7.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(278, 565);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(100, 21);
            richTextBox8.TabIndex = 4;
            richTextBox8.Text = "";
            richTextBox8.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 605);
            Controls.Add(button1);
            Controls.Add(richTextBox8);
            Controls.Add(richTextBox7);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Order Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private RichTextBox richTextBox1;
        private Label label11;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button1;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox8;
    }
}
