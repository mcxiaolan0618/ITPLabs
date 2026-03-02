
namespace Lab2C
{
    partial class Lab2C
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
            txtNum1 = new TextBox();
            bt1 = new Button();
            lbl2 = new Label();
            lstStudents = new ListBox();
            lbResult = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Window;
            txtNum1.BorderStyle = BorderStyle.None;
            txtNum1.Location = new Point(195, 14);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(201, 16);
            txtNum1.TabIndex = 7;
            // 
            // bt1
            // 
            bt1.Location = new Point(195, 64);
            bt1.Name = "bt1";
            bt1.Size = new Size(95, 23);
            bt1.TabIndex = 8;
            bt1.Text = "Add an Item";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(195, 180);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(134, 15);
            lbl2.TabIndex = 10;
            lbl2.Text = "[double click to delect]";
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(12, 14);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(163, 244);
            lstStudents.TabIndex = 11;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            lstStudents.DoubleClick += lstStudents_DoubleClick;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Control;
            lbResult.BorderStyle = BorderStyle.Fixed3D;
            lbResult.Location = new Point(12, 295);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(384, 52);
            lbResult.TabIndex = 14;
            // 
            // Lab2C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(lstStudents);
            Controls.Add(lbl2);
            Controls.Add(bt1);
            Controls.Add(txtNum1);
            Name = "Lab2C";
            Text = "Frm2C";
            Load += frm2C_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtNum1;
        private Button bt1;
        private Label lbl2;
        private ListBox lstStudents;
        private Label lbResult;
    }
}
