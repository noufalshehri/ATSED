namespace ATSED_Staff
{
    partial class userDataAR
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
            this.enterButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(1071, 16);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 67);
            this.homeButton.TabIndex = 15;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Crimson;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(112, 237);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(152, 51);
            this.enterButton.TabIndex = 13;
            this.enterButton.Text = "إدخـال";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(76, 172);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.Size = new System.Drawing.Size(212, 31);
            this.passTextBox.TabIndex = 12;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passLabel.ForeColor = System.Drawing.Color.Crimson;
            this.passLabel.Location = new System.Drawing.Point(178, 123);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(123, 49);
            this.passLabel.TabIndex = 11;
            this.passLabel.Text = "الرقم السري";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(76, 75);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(212, 31);
            this.idTextBox.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Hacen Typographer Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.idLabel.ForeColor = System.Drawing.Color.Crimson;
            this.idLabel.Location = new System.Drawing.Point(163, 32);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(138, 49);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "اسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Typographer Book", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(692, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 123);
            this.label1.TabIndex = 8;
            this.label1.Text = "أدخل بـياناتك";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATSED_Staff.Properties.Resources.langbubble;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.enterButton);
            this.panel2.Controls.Add(this.passTextBox);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.passLabel);
            this.panel2.Location = new System.Drawing.Point(78, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 389);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 598);
            this.panel1.TabIndex = 18;
            // 
            // userDataAR
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userDataAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userDataAR";
            this.Load += new System.EventHandler(this.UserDataAR_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}