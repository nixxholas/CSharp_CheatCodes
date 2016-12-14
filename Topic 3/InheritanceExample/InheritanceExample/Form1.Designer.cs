namespace InheritanceExample
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAddCow = new System.Windows.Forms.Button();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 12);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(508, 446);
            this.txtInfo.TabIndex = 0;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(542, 12);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(186, 94);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAddCow
            // 
            this.btnAddCow.Location = new System.Drawing.Point(542, 112);
            this.btnAddCow.Name = "btnAddCow";
            this.btnAddCow.Size = new System.Drawing.Size(186, 94);
            this.btnAddCow.TabIndex = 2;
            this.btnAddCow.Text = "Add Cow";
            this.btnAddCow.UseVisualStyleBackColor = true;
            this.btnAddCow.Click += new System.EventHandler(this.btnAddCow_Click);
            // 
            // btnAddDog
            // 
            this.btnAddDog.Location = new System.Drawing.Point(542, 212);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(186, 94);
            this.btnAddDog.TabIndex = 3;
            this.btnAddDog.Text = "Add Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(542, 312);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(186, 94);
            this.btnAddMore.TabIndex = 4;
            this.btnAddMore.Text = "Add More";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 470);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.btnAddDog);
            this.Controls.Add(this.btnAddCow);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.txtInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAddCow;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.Button btnAddMore;
    }
}

