﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Npgsql;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace TASK_APP
{
    public partial class TaskApp : Form
    {
        public TaskApp()
        {
            InitializeComponent();
            LoadData();
            dgvTasks.CellClick += dgvTasks_CellContentClick;
        }


        private void LoadData()
        {
            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT TaskID, Task_Name, Task_Status from Task where UserID = " + Login.uid;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgvTasks.DataSource = dt;

            conn.Close();
            UpdateTaskCountLabel(); // Update the task count label after loading data
            selectUsername();

        }

        private void AmendDatabase(string txtQuery)
        {

            try
            {
                // Your code that may throw an exception goes here
                NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
                conn.Open();

                string query = txtQuery;
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                taskInput.Text = "";
                IDField.Text = "";
     }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbquery = "INSERT INTO Task(Task_Name, UserID)" + "VALUES ('" + taskInput.Text + "','" + Login.uid + "')";

            AmendDatabase(dbquery);
            LoadData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dbquery = "DELETE FROM Task WHERE TaskID = '" + IDField.Text + "'";

            AmendDatabase(dbquery);
            LoadData();
        }

        private string selectedTaskID = ""; // Define a variable to store the selected task ID


        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTasks.Rows[e.RowIndex];
                taskInput.Text = row.Cells[1].Value.ToString();
                IDField.Text = row.Cells[0].Value.ToString();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTasks.Columns["Task_Status"].Index)
            {
                DataGridViewRow row = dgvTasks.Rows[e.RowIndex];
/*                taskInput.Text = row.Cells[1].Value.ToString();
                IDField.Text = row.Cells[0].Value.ToString();
*/
                selectedTaskID = row.Cells["TaskID"].Value.ToString();
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {

            string dbquery = "Update Task set Task_Name='" + taskInput.Text + "' where TaskID = '" + IDField.Text + "'";

            AmendDatabase(dbquery);
            LoadData();

        }

        private void IDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Complete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedTaskID))
            {
                string dbquery = "Update Task set Task_Status='completed' where TaskID = '" + selectedTaskID + "'";
                AmendDatabase(dbquery);
                LoadData();
                selectedTaskID = ""; // Reset the selected task ID
            }
        }

        private void Incomplete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedTaskID))
            {
                string dbquery = "Update Task set Task_Status='not completed' where TaskID = '" + selectedTaskID + "'";
                AmendDatabase(dbquery);
                LoadData();
                selectedTaskID = ""; // Reset the selected task ID
            }
        }

        private void TaskApp_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

/*            counter_Title.Parent = pictureBox1;
            counter_Title.BackColor = Color.Transparent;

            counter.Parent = pictureBox1;
            counter.BackColor = Color.Transparent;
*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void searhFilterBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searhFilterBox.Text))
            {
                NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
                conn.Open();

                string searchTerm = searhFilterBox.Text.ToLower();
                string dbquery = "SELECT * FROM Task WHERE LOWER(Task_Name) LIKE @searchTerm AND UserID = " + Login.uid;


                NpgsqlCommand cmd = new NpgsqlCommand(dbquery, conn);
                cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                DataTable dt = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvTasks.DataSource = dt;

                conn.Close();
            }
            else
            {
                LoadData();
            }

        }
        private void UpdateTaskCountLabel()
        {
            int noOfTasks = CountValidTaskIDs();
            counter.Text = noOfTasks.ToString();
        }

        private int CountValidTaskIDs()
        {
            int count = 0;

            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                if (row.Cells["TaskID"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["TaskID"].Value.ToString()))
                {
                    count++;
                }
            }

            return count;
        }


        private void counter_Click(object sender, EventArgs e)
        {
            UpdateTaskCountLabel();
        }

        private void counter_Title_Click(object sender, EventArgs e)
        {

        }

        private void selectUsername()
        {
/*            string query = "SELECT username from  \"User\" where UserID = " + Login.uid;
*/

            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT username FROM \"User\" WHERE UserID = @UserID";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", Convert.ToInt64(Login.uid)); // Convert Login.uid to Int64 (long)

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = reader["username"].ToString();
                usernameLabel.Text = username;
            }

            conn.Close();

        }


        private void usernameLabel_Click(object sender, EventArgs e)
        {
            selectUsername();
        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
