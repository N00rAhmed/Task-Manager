using System;
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

        }

        private void AmendDatabase(string txtQuery)
        {
            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = txtQuery;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            taskInput.Text = "";
            IDField.Text = "";
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



        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTasks.Rows[e.RowIndex];
                taskInput.Text = row.Cells[1].Value.ToString();
                IDField.Text = row.Cells[0].Value.ToString();
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
            string dbquery = "Update Task set Task_Status='completed' where TaskID = '" + dgvTasks.SelectedRows[0].Cells[0].Value + "'";

            AmendDatabase(dbquery);
            LoadData();
        }

        private void Incomplete_Click(object sender, EventArgs e)
        {
            string dbquery = "Update Task set Task_Status='not completed' where TaskID = '" + dgvTasks.SelectedRows[0].Cells[0].Value + "'";

            AmendDatabase(dbquery);
            LoadData();
        }

        private void TaskApp_Load(object sender, EventArgs e)
        {

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

    }
}
