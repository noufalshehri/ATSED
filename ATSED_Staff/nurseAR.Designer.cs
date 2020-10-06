namespace ATSED_Staff
{
    partial class nurseAR
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
            this.homeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(552, 16);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 67);
            this.homeButton.TabIndex = 30;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.backar;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(1114, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 73);
            this.backButton.TabIndex = 29;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(68, 364);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(388, 66);
            this.button4.TabIndex = 28;
            this.button4.Text = "مرضى تم تشخيصهم";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(68, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(388, 66);
            this.button3.TabIndex = 27;
            this.button3.Text = "المرضى  حسب الأولوية";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(68, 260);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 66);
            this.button2.TabIndex = 26;
            this.button2.Text = "مرضى تمت إزالتهم";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Hacen Typographer Book", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectLabel.ForeColor = System.Drawing.Color.Crimson;
            this.selectLabel.Location = new System.Drawing.Point(642, 228);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(434, 123);
            this.selectLabel.TabIndex = 25;
            this.selectLabel.Text = "اختر أحد الخدمات";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 598);
            this.panel1.TabIndex = 31;
            // 
            // nurseAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nurseAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nurseAR";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Panel panel1;
    }
}