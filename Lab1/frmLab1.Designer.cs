

namespace Lab1
{
    partial class frmLab1
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            lblSum = new Label();
            txtNum3 = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Info;
            txtNum1.Location = new Point(55, 97);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.BackColor = SystemColors.Control;
            lblNum1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum1.ForeColor = SystemColors.WindowText;
            lblNum1.Location = new Point(55, 68);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(61, 26);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.BackColor = SystemColors.Control;
            lblNum2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum2.ForeColor = SystemColors.WindowText;
            lblNum2.Location = new Point(275, 68);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(64, 26);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Num2";
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Info;
            txtNum2.Location = new Point(275, 97);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(166, 176);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(50, 26);
            lblSum.TabIndex = 5;
            lblSum.Text = "Sum";
            // 
            // txtNum3
            // 
            txtNum3.BackColor = SystemColors.Info;
            txtNum3.Location = new Point(166, 205);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(166, 122);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 338);
            Controls.Add(btnAdd);
            Controls.Add(lblSum);
            Controls.Add(txtNum3);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Name = "frmLab1";
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Label lblSum;
        private TextBox txtNum3;
        private Button btnAdd;
    }
}
