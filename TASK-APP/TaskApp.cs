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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
