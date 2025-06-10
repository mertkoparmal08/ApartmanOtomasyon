namespace ApartmanOtomasyon
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
            giderler = new Button();
            gelirler = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // giderler
            // 
            giderler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            giderler.Location = new Point(408, 360);
            giderler.Name = "giderler";
            giderler.Size = new Size(152, 80);
            giderler.TabIndex = 3;
            giderler.Text = "Giderler";
            giderler.UseVisualStyleBackColor = true;
            giderler.Click += giderler_Click;
            // 
            // gelirler
            // 
            gelirler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gelirler.Location = new Point(168, 360);
            gelirler.Name = "gelirler";
            gelirler.Size = new Size(152, 80);
            gelirler.TabIndex = 2;
            gelirler.Text = "Gelirler";
            gelirler.UseVisualStyleBackColor = true;
            gelirler.Click += gelirler_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(144, 72);
            label1.Name = "label1";
            label1.Size = new Size(456, 72);
            label1.TabIndex = 4;
            label1.Text = "APARTMAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(224, 144);
            label2.Name = "label2";
            label2.Size = new Size(288, 72);
            label2.TabIndex = 5;
            label2.Text = "Otomasyonu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(giderler);
            Controls.Add(gelirler);
            Name = "Form1";
            Text = "Apartman Otomasyonu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button giderler;
        private Button gelirler;
        private Label label1;
        private Label label2;
    }
}
