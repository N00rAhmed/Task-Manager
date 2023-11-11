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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;

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

            /*SQL query made in cockroachDB*/
            string query = "SELECT * FROM \"User\"";
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvData.Rows[e.RowIndex];
                UserIDField.Text = row.Cells[0].Value.ToString();
           }

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
            string dbquery = "DELETE FROM \"User\" WHERE UserID = '" + UserIDField.Text + "'";
            string query = "DELETE FROM Task WHERE UserID = '" + UserIDField.Text + "'";
            AmendDatabase(dbquery);
            AmendDatabase(query);
            LoadData();
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
    }
}
