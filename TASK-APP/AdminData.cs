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
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\TSK-APP\taskAppDB.db");
            conn.Open();

            string query = "SELECT * FROM User";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvData.DataSource = dt;
            //dgvTasks.Columns[3].Visible = false;





            conn.Close();

        }



        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*            string dbquery = "SELECT * FROM User";
            AmendDatabase(dbquery);
            LoadData();
*/
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();

        }
    }
}
