﻿namespace TASK_APP
{
    partial class AllTasksPage
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
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.MainAdminPage = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(61, 42);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.Size = new System.Drawing.Size(731, 383);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(929, 42);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 55);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainAdminPage
            // 
            this.MainAdminPage.Location = new System.Drawing.Point(929, 135);
            this.MainAdminPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainAdminPage.Name = "MainAdminPage";
            this.MainAdminPage.Size = new System.Drawing.Size(121, 55);
            this.MainAdminPage.TabIndex = 2;
            this.MainAdminPage.Text = "Admin Main";
            this.MainAdminPage.UseVisualStyleBackColor = true;
            this.MainAdminPage.Click += new System.EventHandler(this.MainAdminPage_Click);
            // 
            // IDField
            // 
            this.IDField.Location = new System.Drawing.Point(881, 274);
            this.IDField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(71, 22);
            this.IDField.TabIndex = 3;
            this.IDField.TextChanged += new System.EventHandler(this.IDField_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(961, 274);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(68, 25);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TASK_APP.Properties.Resources.autumn_schrock_aurora_moon_488x305;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AllTasksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.MainAdminPage);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllTasksPage";
            this.Text = "AllTasksPage";
            this.Load += new System.EventHandler(this.AllTasksPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button MainAdminPage;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}