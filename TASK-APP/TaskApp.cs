using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;


namespace TASK_APP
{
    public partial class TaskApp : Form
    {
        public TaskApp()
        {
            InitializeComponent();
            //DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            ////dgvCmb.ValueType = typeof(bool);
            //dgvCmb.TrueValue = true;
            //dgvCmb.FalseValue = false;
            //dgvCmb.Name = "Chk";
            //dgvCmb.HeaderText = "CheckBox";
            //dgvTasks.Columns.Insert(0, dgvCmb);
            LoadData();
            //Update_Checkbox();
        }
        /*        https://www.aspsnippets.com/questions/120372/Bind-Populate-CheckBox-inside-DataGridView-from-Database-using-C-and-VBNet-in-Windows-Application/
         *        https://code-maze.com/csharp-convert-string-to-bool/
        */
        //private void Update_Checkbox()
        //{
        //    foreach (DataGridViewRow row in dgvTasks.Rows)
        //    {

        //        //DataGridViewCheckBoxCell oCell = row.Cells["Chk"] as DataGridViewCheckBoxCell;

        //        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
        //        bool bChecked = (Convert.ToBoolean(row.Cells[3].Value));
        //        if (bChecked)
        //        {
        //            chk.Value = chk.TrueValue;

        //        }
        //        else
        //        {
        //            chk.Value = chk.FalseValue;
        //        }

        //        //bool bChecked = (Convert.ToBoolean(row.Cells[3].Value));
        //        //if (bChecked)
        //        //{
        //        //    row.Cells["Chk"].Value = true;
        //        //}
        //        //else
        //        //{
        //        //    row.Cells["Chk"].Value = false;

        //        //}
        //    }
        //}


        private void LoadData()
        {
            /*            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\taskappDB\taskAppDB.db");
                        SqlCommand cmd = new SqlCommand("SELECT Task_Name from Task");


                        SqlDataAdapter da = new SqlDataAdapter();

                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        listBox1.DataSource = dt;
                        listBox1.DisplayMember = "Task_Name";
            */
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\TSK-APP\taskAppDB.db");
            conn.Open();

            string query = "SELECT TaskID, Task_Name, Task_Status from Task where UserID = " + Login.uid;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvTasks.DataSource = dt;
            //dgvTasks.Columns[3].Visible = false;





            /*            listBox1.DataSource = dt;
            */
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
            taskInput.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options options = new Options();
            options.Show();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbquery = "INSERT INTO Task(Task_Name, UserID)" + "VALUES ('" + taskInput.Text + "','" + Login.uid + "')";

            AmendDatabase(dbquery);

            LoadData();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*            foreach (DataGridViewCell cell in dgvTasks.SelectedCells)
                        {
                            string dbquery = "DELETE FROM Task WHERE Task_Name = '" + dgvTasks.SelectedCells + "'";
                            AmendDatabase(dbquery);
                            LoadData();

                        }
            */
  
            string dbquery = "DELETE FROM Task WHERE Task_Name = '" + taskInput.Text + "'";
            AmendDatabase(dbquery);
            LoadData();

        }





        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
/*            string dbquery = "Update Task set Task_Name='" + textBox1.Text + "'";
*/
            string dbquery = "Update Task set Task_Name='" + taskInput.Text + "' where TaskID = '" + IDField.Text + "'";


            AmendDatabase(dbquery);
            LoadData();

        }

        private void IDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Complete_Click(object sender, EventArgs e)
        {
            //dgvTasks.SelectedRows[0].Cells[1].Value;
            string dbquery = "Update Task set Task_Status='completed' where TaskID = '" + dgvTasks.SelectedRows[0].Cells[0].Value + "'";


            AmendDatabase(dbquery);
            LoadData();
        }

        private void Incomplete_Click(object sender, EventArgs e)
        {
            string dbquery = "Update Task set Task_Status='not completed' where TaskID = '" + dgvTasks.SelectedRows[0].Cells[0].Value + "'";


            AmendDatabase(dbquery);
            LoadData();
        }
    }
}
