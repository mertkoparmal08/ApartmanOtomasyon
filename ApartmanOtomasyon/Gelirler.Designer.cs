﻿namespace ApartmanOtomasyon
{
    partial class Gelirler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.ForestGreen;
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(32, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(650, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelirler";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(192, 120);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(128, 30);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBox1.Location = new Point(200, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 39);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(352, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(56, 120);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 5;
            label2.Text = "Tutar:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(472, 120);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 3;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(120, 40);
            label1.TabIndex = 0;
            label1.Text = "Daire No:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.Green;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(208, 288);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(88, 184);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.ForeColor = Color.Green;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(304, 288);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(64, 184);
            listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox3.ForeColor = Color.Green;
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(376, 288);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(104, 184);
            listBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(216, 272);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 6;
            label3.Text = "Daire No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 9F);
            label4.Location = new Point(312, 272);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 7;
            label4.Text = "Tutar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 9F);
            label5.Location = new Point(384, 272);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 8;
            label5.Text = "Tarih";
            // 
            // Gelirler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Gelirler";
            Text = "Gelirler";
            Load += Gelirler_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}