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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskInput
            // 
            this.taskInput.Location = new System.Drawing.Point(185, 103);
            this.taskInput.Name = "taskInput";
            this.taskInput.Size = new System.Drawing.Size(191, 20);
            this.taskInput.TabIndex = 2;
            this.taskInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(86, 156);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(369, 255);
            this.dgvTasks.TabIndex = 5;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(567, 103);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(83, 33);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // IDField
            // 
            this.IDField.Location = new System.Drawing.Point(185, 130);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(191, 20);
            this.IDField.TabIndex = 9;
            this.IDField.TextChanged += new System.EventHandler(this.IDField_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(148, 133);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(15, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "id";
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(185, 417);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(69, 38);
            this.Complete.TabIndex = 11;
            this.Complete.Text = "complete";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // Incomplete
            // 
            this.Incomplete.Location = new System.Drawing.Point(284, 417);
            this.Incomplete.Name = "Incomplete";
            this.Incomplete.Size = new System.Drawing.Size(69, 38);
            this.Incomplete.TabIndex = 12;
            this.Incomplete.Text = "incomplete";
            this.Incomplete.UseVisualStyleBackColor = true;
            this.Incomplete.Click += new System.EventHandler(this.Incomplete_Click);
            // 
            // TaskApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "TaskApp";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
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
    }
}