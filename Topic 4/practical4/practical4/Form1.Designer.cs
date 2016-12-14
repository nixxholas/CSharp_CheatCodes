namespace practical4
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.txtAsgn1 = new System.Windows.Forms.TextBox();
            this.txtAsgn2 = new System.Windows.Forms.TextBox();
            this.txtGP = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weighted Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mid-Semester Test (20%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assignment 1 (25%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment 2 (35%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "General Performance (20%)";
            // 
            // txtMST
            // 
            this.txtMST.Location = new System.Drawing.Point(552, 96);
            this.txtMST.Margin = new System.Windows.Forms.Padding(4);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(121, 29);
            this.txtMST.TabIndex = 5;
            // 
            // txtAsgn1
            // 
            this.txtAsgn1.Location = new System.Drawing.Point(552, 133);
            this.txtAsgn1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsgn1.Name = "txtAsgn1";
            this.txtAsgn1.Size = new System.Drawing.Size(121, 29);
            this.txtAsgn1.TabIndex = 6;
            // 
            // txtAsgn2
            // 
            this.txtAsgn2.Location = new System.Drawing.Point(552, 170);
            this.txtAsgn2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsgn2.Name = "txtAsgn2";
            this.txtAsgn2.Size = new System.Drawing.Size(121, 29);
            this.txtAsgn2.TabIndex = 7;
            // 
            // txtGP
            // 
            this.txtGP.Location = new System.Drawing.Point(552, 207);
            this.txtGP.Margin = new System.Windows.Forms.Padding(4);
            this.txtGP.Name = "txtGP";
            this.txtGP.Size = new System.Drawing.Size(121, 29);
            this.txtGP.TabIndex = 8;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(362, 274);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(166, 73);
            this.btnCompute.TabIndex = 9;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(304, 357);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 24);
            this.lblAverage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 574);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtGP);
            this.Controls.Add(this.txtAsgn2);
            this.Controls.Add(this.txtAsgn1);
            this.Controls.Add(this.txtMST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "APPD Weighted Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMST;
        private System.Windows.Forms.TextBox txtAsgn1;
        private System.Windows.Forms.TextBox txtAsgn2;
        private System.Windows.Forms.TextBox txtGP;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblAverage;
    }
}

