namespace practical4qn3
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
            this.GuestInput = new System.Windows.Forms.TextBox();
            this.firstTime = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.RoomsInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NightsInput = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TwinCheck = new System.Windows.Forms.RadioButton();
            this.DoubleCheck = new System.Windows.Forms.RadioButton();
            this.SingleCheck = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Name : ";
            // 
            // GuestInput
            // 
            this.GuestInput.Location = new System.Drawing.Point(166, 65);
            this.GuestInput.Name = "GuestInput";
            this.GuestInput.Size = new System.Drawing.Size(177, 20);
            this.GuestInput.TabIndex = 2;
            // 
            // firstTime
            // 
            this.firstTime.AutoSize = true;
            this.firstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTime.Location = new System.Drawing.Point(53, 107);
            this.firstTime.Name = "firstTime";
            this.firstTime.Size = new System.Drawing.Size(258, 24);
            this.firstTime.TabIndex = 3;
            this.firstTime.Text = "First Time Guest (15% Discount)";
            this.firstTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrival Date : ";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(158, 152);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(196, 20);
            this.dateInput.TabIndex = 5;
            this.dateInput.Value = new System.DateTime(2015, 11, 23, 14, 44, 59, 0);
            // 
            // RoomsInput
            // 
            this.RoomsInput.FormattingEnabled = true;
            this.RoomsInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.RoomsInput.Location = new System.Drawing.Point(127, 192);
            this.RoomsInput.Name = "RoomsInput";
            this.RoomsInput.Size = new System.Drawing.Size(33, 21);
            this.RoomsInput.TabIndex = 6;
            this.RoomsInput.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rooms : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nights : ";
            // 
            // NightsInput
            // 
            this.NightsInput.FormattingEnabled = true;
            this.NightsInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.NightsInput.Location = new System.Drawing.Point(252, 192);
            this.NightsInput.Name = "NightsInput";
            this.NightsInput.Size = new System.Drawing.Size(46, 21);
            this.NightsInput.TabIndex = 9;
            this.NightsInput.Text = "1";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(53, 244);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(557, 31);
            this.btn.TabIndex = 10;
            this.btn.Text = "Display Room Total";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TwinCheck);
            this.groupBox1.Controls.Add(this.DoubleCheck);
            this.groupBox1.Controls.Add(this.SingleCheck);
            this.groupBox1.Location = new System.Drawing.Point(428, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TwinCheck
            // 
            this.TwinCheck.AutoSize = true;
            this.TwinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwinCheck.Location = new System.Drawing.Point(16, 82);
            this.TwinCheck.Name = "TwinCheck";
            this.TwinCheck.Size = new System.Drawing.Size(54, 20);
            this.TwinCheck.TabIndex = 2;
            this.TwinCheck.TabStop = true;
            this.TwinCheck.Text = "Twin";
            this.TwinCheck.UseVisualStyleBackColor = true;
            // 
            // DoubleCheck
            // 
            this.DoubleCheck.AutoSize = true;
            this.DoubleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleCheck.Location = new System.Drawing.Point(16, 56);
            this.DoubleCheck.Name = "DoubleCheck";
            this.DoubleCheck.Size = new System.Drawing.Size(70, 20);
            this.DoubleCheck.TabIndex = 1;
            this.DoubleCheck.TabStop = true;
            this.DoubleCheck.Text = "Double";
            this.DoubleCheck.UseVisualStyleBackColor = true;
            // 
            // SingleCheck
            // 
            this.SingleCheck.AutoSize = true;
            this.SingleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleCheck.Location = new System.Drawing.Point(16, 30);
            this.SingleCheck.Name = "SingleCheck";
            this.SingleCheck.Size = new System.Drawing.Size(64, 20);
            this.SingleCheck.TabIndex = 0;
            this.SingleCheck.TabStop = true;
            this.SingleCheck.Text = "Single";
            this.SingleCheck.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(53, 298);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(557, 125);
            this.txtOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 435);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.NightsInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomsInput);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstTime);
            this.Controls.Add(this.GuestInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GuestInput;
        private System.Windows.Forms.CheckBox firstTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.ComboBox RoomsInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NightsInput;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TwinCheck;
        private System.Windows.Forms.RadioButton DoubleCheck;
        private System.Windows.Forms.RadioButton SingleCheck;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

