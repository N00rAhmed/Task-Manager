namespace TASK_APP
{
    partial class Options
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
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(479, 123);
            this.createAccountBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(141, 44);
            this.createAccountBtn.TabIndex = 0;
            this.createAccountBtn.Text = "create account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(479, 204);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(141, 44);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(479, 294);
            this.AdminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(141, 44);
            this.AdminBtn.TabIndex = 2;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TASK_APP.Properties.Resources.ocean_3605547__480;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(971, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(96, 38);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeBtn;
    }
}

