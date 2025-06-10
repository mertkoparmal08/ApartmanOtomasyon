namespace ApartmanOtomasyon
{
    partial class Giderler
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
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(464, 288);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(176, 184);
            listBox3.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(320, 288);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(134, 184);
            listBox2.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(120, 288);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(192, 184);
            listBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.ForestGreen;
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(40, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(650, 210);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Gider Ekle";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(80, 168);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(125, 35);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "Temizlik";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(80, 128);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 35);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "Asansör";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(80, 88);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 35);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Su";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(80, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 35);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Elektrik";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(384, 56);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(128, 30);
            numericUpDown1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(280, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(248, 56);
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
            button1.Location = new Point(400, 144);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 3;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 272);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 10;
            label1.Text = "Gider";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 272);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 11;
            label3.Text = "Tutar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 272);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 12;
            label4.Text = "Tarih";
            // 
            // Giderler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Giderler";
            Text = "Giderler";
            Load += Giderler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}