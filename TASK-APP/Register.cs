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
            this.Hide();
            /*            string dbquery = "INSERT INTO \"User\"(First_Name, Last_Name, DOB, username, Password)" + "VALUES ('" + firstname.Text + "', '" + lastname.Text + "', '" + DOB.Text + "', '" + username.Text + "', '" + password.Text + "')";
            */
            string dbquery = "INSERT INTO \"User\" (First_Name, Last_Name, DOB, username, Password) VALUES ('" + firstname.Text + "', '" + lastname.Text + "', '" + DOB.Text + "', '" + username.Text + "', '" + password.Text + "')";
            string query = "INSERT INTO Login(username, Password, UserID) SELECT username, Password, UserID FROM \"User\"";

            AmendDatabase(dbquery);
            AmendDatabase(query);

            Login login = new Login();
            login.Show();
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
            DOB.Text = "";
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
    }
}
