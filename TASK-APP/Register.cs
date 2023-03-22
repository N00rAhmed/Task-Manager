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



            string dbquery = "INSERT INTO User(First_Name, Last_Name, DOB, UserName, Password)" + "VALUES ('" + firstname.Text + "', '" + lastname.Text + "', '" + DOB.Text + "', '" + username.Text + "', '" + password.Text + "')";
            string query = "INSERT INTO Login(UserName, Password, UserID) SELECT UserName, Password, UserID FROM User";

/*            INSERT INTO Login(UserName, Password, UserID) SELECT UserName, Password, UserID FROM User;
*/
            AmendDatabase(dbquery);
            AmendDatabase(query);


            Login login = new Login();
            login.Show();


        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = E:\TSK-APP\taskAppDB.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
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
    }
}
