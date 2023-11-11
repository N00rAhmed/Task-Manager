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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Data.SqlClient;
using Npgsql;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace TASK_APP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the form fields are empty
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(dobDatePicker.Text) || string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {
                // Show a popup message for incorrect details
                string message = "Incorrect details. Please fill in all the fields.";
                MessageBox.Show(message);
                return; // Exit the method without further processing
            }

            // If all fields are filled, proceed with registration
            this.Hide();

            bool register = false;

            /* string dbquery = "INSERT INTO \"User\"(First_Name, Last_Name, DOB, username, Password)" + "VALUES ('" + firstname.Text + "', '" + lastname.Text + "', '" + DOB.Text + "', '" + username.Text + "', '" + password.Text + "')"; */
            string dbquery = "INSERT INTO \"User\" (First_Name, Last_Name, DOB, username, Password) VALUES ('" + firstname.Text + "', '" + lastname.Text + "', '" + dobDatePicker.Text + "', '" + username.Text + "', '" + password.Text + "')";
/*            string query = "INSERT INTO Login(username, Password, UserID) SELECT username, Password, UserID FROM \"User\"";
*/
            AmendDatabase(dbquery);
/*            AmendDatabase(query);
*/
            Login login = new Login();
            login.Show();
            register = true;

            if (register == false)
            {
                string message = "Incorrect login details";
                MessageBox.Show(message);
                Register registerPage = new Register();
                registerPage.Show();
            }
        }

        private void AmendDatabase(string txtQuery)
        {
            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = txtQuery;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            firstname.Text = "";
            lastname.Text = "";
            dobDatePicker.Text = "";
            username.Text = "";
            password.Text = "";


        }


        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
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

        private void dobDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
