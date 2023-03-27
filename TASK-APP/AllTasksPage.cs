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

namespace TASK_APP
{
    public partial class AllTasksPage : Form
    {
        public AllTasksPage()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\TSK-APP\taskAppDB.db");
            conn.Open();

            string query = "SELECT * FROM Task";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvTasks.DataSource = dt;

            conn.Close();

        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\TSK-APP\taskAppDB.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            IDField.Text = "";
        }


        private void AllTasksPage_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();

        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminData admindata = new AdminData();
            admindata.Show();

        }

        private void IDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string dbquery = "DELETE FROM Task WHERE TaskID = '" + IDField.Text + "'";
            AmendDatabase(dbquery);
            LoadData();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
