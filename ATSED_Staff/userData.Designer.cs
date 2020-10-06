namespace ATSED_Staff
{
    partial class userData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.englishButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(138, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(662, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 598);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATSED_Staff.Properties.Resources.langbubble;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.englishButton);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.passTextBox);
            this.panel2.Controls.Add(this.passLabel);
            this.panel2.Location = new System.Drawing.Point(79, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 389);
            this.panel2.TabIndex = 5;
            // 
            // englishButton
            // 
            this.englishButton.BackColor = System.Drawing.Color.Crimson;
            this.englishButton.FlatAppearance.BorderSize = 0;
            this.englishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.englishButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.ForeColor = System.Drawing.Color.White;
            this.englishButton.Location = new System.Drawing.Point(105, 235);
            this.englishButton.Margin = new System.Windows.Forms.Padding(4);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(152, 47);
            this.englishButton.TabIndex = 5;
            this.englishButton.Text = "Enter";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.Crimson;
            this.idLabel.Location = new System.Drawing.Point(76, 51);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(131, 29);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "User Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(76, 83);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(212, 30);
            this.idTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(76, 181);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.Size = new System.Drawing.Size(212, 30);
            this.passTextBox.TabIndex = 4;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Crimson;
            this.passLabel.Location = new System.Drawing.Point(76, 149);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(114, 29);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(567, 16);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 67);
            this.homeButton.TabIndex = 7;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // userData
            // 
            this.AcceptButton = this.englishButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userData";
            this.Load += new System.EventHandler(this.UserData_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button englishButton;
    }
}