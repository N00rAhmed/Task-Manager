using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;

namespace TASK_APP
{
    public partial class AdminData : Form
    {
        public AdminData()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT * FROM Login";
            /*\"User\"*/
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgvData.DataSource = dt;

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
            UserIDField.Text = "";
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();

        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllTasksPage alltaskspage = new AllTasksPage();
            alltaskspage.Show();

        }



        private void UderIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            string dbquery = "DELETE FROM Login WHERE UserID = '" + UserIDField.Text + "'";
            string query = "DELETE FROM Task WHERE UserID = '" + UserIDField.Text + "'";
            AmendDatabase(dbquery);
            AmendDatabase(query);
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
