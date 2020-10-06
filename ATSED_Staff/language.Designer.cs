namespace ATSED_Staff
{
    partial class language
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
            this.englishButton = new System.Windows.Forms.Button();
            this.englishLabel = new System.Windows.Forms.Label();
            this.ARLabel = new System.Windows.Forms.Label();
            this.ARButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // englishButton
            // 
            this.englishButton.BackColor = System.Drawing.Color.Crimson;
            this.englishButton.FlatAppearance.BorderSize = 0;
            this.englishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.englishButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.ForeColor = System.Drawing.Color.White;
            this.englishButton.Location = new System.Drawing.Point(72, 70);
            this.englishButton.Margin = new System.Windows.Forms.Padding(4);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(231, 75);
            this.englishButton.TabIndex = 0;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Bebas Neue", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.ForeColor = System.Drawing.Color.Crimson;
            this.englishLabel.Location = new System.Drawing.Point(106, 221);
            this.englishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(444, 72);
            this.englishLabel.TabIndex = 1;
            this.englishLabel.Text = "Choose The Language";
            // 
            // ARLabel
            // 
            this.ARLabel.AutoSize = true;
            this.ARLabel.Font = new System.Drawing.Font("Hacen Typographer Book", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ARLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ARLabel.Location = new System.Drawing.Point(129, 261);
            this.ARLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(380, 111);
            this.ARLabel.TabIndex = 3;
            this.ARLabel.Text = "الرجاء اختيار اللغة";
            // 
            // ARButton
            // 
            this.ARButton.BackColor = System.Drawing.Color.Crimson;
            this.ARButton.FlatAppearance.BorderSize = 0;
            this.ARButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARButton.Font = new System.Drawing.Font("Hacen Typographer Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ARButton.ForeColor = System.Drawing.Color.White;
            this.ARButton.Location = new System.Drawing.Point(72, 165);
            this.ARButton.Margin = new System.Windows.Forms.Padding(4);
            this.ARButton.Name = "ARButton";
            this.ARButton.Size = new System.Drawing.Size(231, 75);
            this.ARButton.TabIndex = 2;
            this.ARButton.Text = "العربية";
            this.ARButton.UseVisualStyleBackColor = false;
            this.ARButton.Click += new System.EventHandler(this.ARButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(663, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 598);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATSED_Staff.Properties.Resources.langbubble;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ARButton);
            this.panel2.Controls.Add(this.englishButton);
            this.panel2.Location = new System.Drawing.Point(74, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 389);
            this.panel2.TabIndex = 5;
            // 
            // language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ARLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "language";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "language";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.Button ARButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

