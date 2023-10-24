using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TASK_APP
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();

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
