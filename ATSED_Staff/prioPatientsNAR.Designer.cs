namespace ATSED_Staff
{
    partial class prioPatientsNAR
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(25, 16);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 67);
            this.homeButton.TabIndex = 23;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ATSED_Staff.Properties.Resources.backar;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(1105, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 73);
            this.backButton.TabIndex = 22;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Typographer Book", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(409, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 82);
            this.label2.TabIndex = 25;
            this.label2.Text = "المرضى  حسب الأولوية";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ATSED_Staff.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(986, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 37);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ATSED_Staff.Properties.Resources.close;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(910, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 31);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 438);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // prioPatientsNAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "prioPatientsNAR";
            this.Text = "prioPatientsNAR";
            this.Load += new System.EventHandler(this.PrioPatientsNAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}