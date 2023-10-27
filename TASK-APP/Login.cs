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
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        public static string uid = "";

        public Login()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT UserName, Password, UserID from \"User\"";

            /*            string query = "SELECT UserName, Password, UserID from Login";
            */            /*            string query = "SELECT UserName, Password, UserID from User";
                        */
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool login = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr["UserName"].ToString() == nameInput.Text && dr["Password"].ToString() == passwordInput.Text)
                {
                    uid = dr["UserID"].ToString();

                    TaskApp f3 = new TaskApp();
                    f3.Show();
                    login = true;
                    break;
                }

            }


            if (login == false)
            {
                string message = "Incorrect login details";
                MessageBox.Show(message);
                Login f2 = new Login();
                f2.Show();
            }


        }



        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
