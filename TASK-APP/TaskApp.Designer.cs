namespace TASK_APP
{
    partial class TaskApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.taskInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Complete = new System.Windows.Forms.Button();
            this.Incomplete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskInput
            // 
            this.taskInput.Location = new System.Drawing.Point(247, 127);
            this.taskInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskInput.Name = "taskInput";
            this.taskInput.Size = new System.Drawing.Size(253, 22);
            this.taskInput.TabIndex = 2;
            this.taskInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(115, 192);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.Size = new System.Drawing.Size(492, 314);
            this.dgvTasks.TabIndex = 5;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 119);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(720, 119);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 41);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // IDField
            // 
            this.IDField.Location = new System.Drawing.Point(247, 160);
            this.IDField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(253, 22);
            this.IDField.TabIndex = 9;
            this.IDField.TextChanged += new System.EventHandler(this.IDField_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(197, 164);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 16);
            this.ID.TabIndex = 10;
            this.ID.Text = "id";
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(247, 513);
            this.Complete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(92, 47);
            this.Complete.TabIndex = 11;
            this.Complete.Text = "complete";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // Incomplete
            // 
            this.Incomplete.Location = new System.Drawing.Point(379, 513);
            this.Incomplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Incomplete.Name = "Incomplete";
            this.Incomplete.Size = new System.Drawing.Size(92, 47);
            this.Incomplete.TabIndex = 12;
            this.Incomplete.Text = "incomplete";
            this.Incomplete.UseVisualStyleBackColor = true;
            this.Incomplete.Click += new System.EventHandler(this.Incomplete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TASK_APP.Properties.Resources.istockphoto_517188688_1024x1024;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TaskApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Incomplete);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskApp";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.TaskApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox taskInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Button Incomplete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}