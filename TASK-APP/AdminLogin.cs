using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;

namespace TASK_APP
{
    public partial class AdminLogin : Form
    {
        DataTable dt = new DataTable();
        public static string uid = "";


        public AdminLogin()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT AdminID, UserName, Password from AdminLogin";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            bool login = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr["UserName"].ToString() == AdminUser.Text && dr["Password"].ToString() == AdminPassword.Text)
                {
                    uid = dr["AdminID"].ToString();

                    AdminData admindata = new AdminData();
                    admindata.Show();
                    login = true;
                    break;
                }

            }


            if (login == false)
            {
                string message = "Incorrect login details";
                MessageBox.Show(message);
                Options options = new Options();
                options.Show();
            }



        }

        private void AdminUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();

        }
    }
}
