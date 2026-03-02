namespace Lab2B
{
    partial class Lab2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2B));
            lbl1 = new Label();
            txtNum1 = new TextBox();
            groupBox1 = new GroupBox();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            pb1 = new PictureBox();
            pb3 = new PictureBox();
            pb2 = new PictureBox();
            pb4 = new PictureBox();
            label1 = new Label();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(26, 26);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(126, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enter your name here :";
            lbl1.Click += label1_Click;
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Window;
            txtNum1.BorderStyle = BorderStyle.None;
            txtNum1.Location = new Point(158, 26);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(201, 16);
            txtNum1.TabIndex = 6;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb4);
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Location = new Point(26, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 210);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(15, 157);
            rb4.Name = "rb4";
            rb4.Size = new Size(58, 19);
            rb4.TabIndex = 9;
            rb4.TabStop = true;
            rb4.Text = "&Sunny";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += rb4_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(15, 115);
            rb3.Name = "rb3";
            rb3.Size = new Size(60, 19);
            rb3.TabIndex = 10;
            rb3.TabStop = true;
            rb3.Text = "S&nowy";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(15, 73);
            rb2.Name = "rb2";
            rb2.Size = new Size(54, 19);
            rb2.TabIndex = 11;
            rb2.TabStop = true;
            rb2.Text = "&Rainy";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(15, 34);
            rb1.Name = "rb1";
            rb1.Size = new Size(63, 19);
            rb1.TabIndex = 8;
            rb1.TabStop = true;
            rb1.Text = "&Cloudy";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // pb1
            // 
            pb1.ErrorImage = (Image)resources.GetObject("pb1.ErrorImage");
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.InitialImage = (Image)resources.GetObject("pb1.InitialImage");
            pb1.Location = new Point(181, 79);
            pb1.Name = "pb1";
            pb1.Size = new Size(70, 65);
            pb1.TabIndex = 8;
            pb1.TabStop = false;
            // 
            // pb3
            // 
            pb3.Image = (Image)resources.GetObject("pb3.Image");
            pb3.Location = new Point(180, 183);
            pb3.Name = "pb3";
            pb3.Size = new Size(71, 65);
            pb3.TabIndex = 9;
            pb3.TabStop = false;
            // 
            // pb2
            // 
            pb2.Image = (Image)resources.GetObject("pb2.Image");
            pb2.Location = new Point(278, 79);
            pb2.Name = "pb2";
            pb2.Size = new Size(71, 65);
            pb2.TabIndex = 10;
            pb2.TabStop = false;
            // 
            // pb4
            // 
            pb4.Image = (Image)resources.GetObject("pb4.Image");
            pb4.Location = new Point(278, 183);
            pb4.Name = "pb4";
            pb4.Size = new Size(70, 65);
            pb4.TabIndex = 11;
            pb4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 298);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 12;
            label1.Click += label1_Click_1;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Control;
            lbResult.BorderStyle = BorderStyle.Fixed3D;
            lbResult.Location = new Point(26, 313);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(333, 52);
            lbResult.TabIndex = 13;
            // 
            // Lab2B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(label1);
            Controls.Add(pb4);
            Controls.Add(pb2);
            Controls.Add(pb3);
            Controls.Add(pb1);
            Controls.Add(groupBox1);
            Controls.Add(txtNum1);
            Controls.Add(lbl1);
            Name = "Lab2B";
            Text = "Frm2B";
            Load += Lab2B_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtNum1;
        private GroupBox groupBox1;
        private RadioButton rb1;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private PictureBox pb1;
        private PictureBox pb3;
        private PictureBox pb2;
        private PictureBox pb4;
        private Label label1;
        private Label lbResult;
    }
}
