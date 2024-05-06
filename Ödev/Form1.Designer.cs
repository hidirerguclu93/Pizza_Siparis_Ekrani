namespace Ödev
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
            textBox1 = new TextBox();
            Ebat = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 509);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Ebat
            // 
            Ebat.AutoSize = true;
            Ebat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Ebat.Location = new Point(30, 88);
            Ebat.Name = "Ebat";
            Ebat.Size = new Size(39, 20);
            Ebat.TabIndex = 1;
            Ebat.Text = "Ebat";
            Ebat.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(30, 138);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Pizzalar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 507);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Toplam";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 507);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "Adet";
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(573, 64);
            label1.TabIndex = 5;
            label1.Text = "Pizza Sipariş Ekranı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 504);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 27);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Küçük Boy", "Orta Boy", "Büyük Boy", "Mega Boy" });
            comboBox1.Location = new Point(115, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 28);
            comboBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(115, 273);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "İnce Kenar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(221, 273);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(106, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Kalın Kenar";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(121, 576);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Kapat";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(253, 576);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Sipariş ver";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "American Hot ", "Callypso", "Turkish ", "Pizza Italiano ", "Etravaganzza" });
            listBox1.Location = new Point(115, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(202, 104);
            listBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox12);
            groupBox1.Controls.Add(checkBox11);
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Location = new Point(115, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 179);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzemeler";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(143, 26);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 24);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Salam";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 116);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(79, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "Ançuez";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 56);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(64, 24);
            checkBox5.TabIndex = 2;
            checkBox5.Text = "Sosis";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 26);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(122, 24);
            checkBox6.TabIndex = 3;
            checkBox6.Text = "Dana Jambon";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 86);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(63, 24);
            checkBox7.TabIndex = 4;
            checkBox7.Text = "Mısır";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 146);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(72, 24);
            checkBox8.TabIndex = 5;
            checkBox8.Text = "Zeytin";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(143, 56);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(69, 24);
            checkBox9.TabIndex = 6;
            checkBox9.Text = "Sucuk";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(143, 86);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(78, 24);
            checkBox10.TabIndex = 7;
            checkBox10.Text = "Mantar";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(143, 146);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(70, 24);
            checkBox11.TabIndex = 8;
            checkBox11.Text = "Peynir";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(143, 116);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(97, 24);
            checkBox12.TabIndex = 9;
            checkBox12.Text = "Ton Balığı";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 715);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Ebat);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Ebat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}
