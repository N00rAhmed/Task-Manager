namespace TASK_APP
{
    partial class AdminData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminData));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.TasksBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIDField = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(134, 135);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(872, 270);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(974, 55);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(81, 30);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Location = new System.Drawing.Point(695, 437);
            this.TasksBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(99, 41);
            this.TasksBtn.TabIndex = 7;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.UseVisualStyleBackColor = true;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TASK_APP.Properties.Resources.tree_736885__480;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserIDField
            // 
            this.UserIDField.Location = new System.Drawing.Point(473, 446);
            this.UserIDField.Margin = new System.Windows.Forms.Padding(4);
            this.UserIDField.Name = "UserIDField";
            this.UserIDField.Size = new System.Drawing.Size(88, 22);
            this.UserIDField.TabIndex = 9;
            this.UserIDField.TextChanged += new System.EventHandler(this.UderIDField_TextChanged);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(416, 449);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(49, 16);
            this.UserID.TabIndex = 10;
            this.UserID.Text = "UserID";
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(569, 437);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(99, 41);
            this.DeleteUser.TabIndex = 11;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // header
            // 
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.btnMaximize);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1067, 38);
            this.header.TabIndex = 12;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(71)))), ((int)(((byte)(49)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1009, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(205)))));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(959, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 28);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(205)))));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(909, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 28);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // AdminData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.header);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.UserIDField);
            this.Controls.Add(this.TasksBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminData";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserIDField;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
    }
}