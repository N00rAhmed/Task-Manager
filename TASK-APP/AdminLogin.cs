using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_APP
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
/*            this.Hide();
            bool login = false;*/
            if (AdminUser.Text == "Admin" && AdminPassword.Text == "pass")
            {
                this.Hide();
                AdminData admindata = new AdminData();
                admindata.Show();

            }
            else
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

    }
}
