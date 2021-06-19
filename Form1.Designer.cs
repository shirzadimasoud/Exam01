
namespace Exam01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.z3TextBox = new System.Windows.Forms.TextBox();
            this.z2TextBox = new System.Windows.Forms.TextBox();
            this.z1TextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 48);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ضلع اول :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 90);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ضلع دوم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 134);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ضلع سوم :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 312);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "مساحت مثلث :";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculateBtn.FlatAppearance.BorderSize = 5;
            this.CalculateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CalculateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.CalculateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(94, 181);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalculateBtn.Size = new System.Drawing.Size(141, 48);
            this.CalculateBtn.TabIndex = 3;
            this.CalculateBtn.Text = "محاسبه";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // z3TextBox
            // 
            this.z3TextBox.Location = new System.Drawing.Point(66, 134);
            this.z3TextBox.Name = "z3TextBox";
            this.z3TextBox.Size = new System.Drawing.Size(198, 22);
            this.z3TextBox.TabIndex = 2;
            this.z3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z2TextBox
            // 
            this.z2TextBox.Location = new System.Drawing.Point(66, 90);
            this.z2TextBox.Name = "z2TextBox";
            this.z2TextBox.Size = new System.Drawing.Size(198, 22);
            this.z2TextBox.TabIndex = 1;
            this.z2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z1TextBox
            // 
            this.z1TextBox.Location = new System.Drawing.Point(66, 48);
            this.z1TextBox.Name = "z1TextBox";
            this.z1TextBox.Size = new System.Drawing.Size(198, 22);
            this.z1TextBox.TabIndex = 0;
            this.z1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(66, 312);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(198, 22);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 401);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.z1TextBox);
            this.Controls.Add(this.z2TextBox);
            this.Controls.Add(this.z3TextBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "محاسبه مساحت مثلث";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox z3TextBox;
        private System.Windows.Forms.TextBox z2TextBox;
        private System.Windows.Forms.TextBox z1TextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

