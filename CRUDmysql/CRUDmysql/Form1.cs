using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUDmysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sqlConnection = "server = localhost; user id = root; password = ; database = d05k13";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(sqlConnection);
            string sql = "SELECT * FROM users";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            query.Fill(item, "users");
            dgView.DataSource = item.Tables["users"].DefaultView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbUsername.Enabled = true;
            lbemail.Enabled = true;
            lbpassword.Enabled = true;
            lbrepass.Enabled = true;
      
            tbUsername.Enabled = true;
            tbUseremail.Enabled = true;
            tbPassword.Enabled = true;
            tbRepass.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string useremail = tbUseremail.Text;
            string password = tbPassword.Text;
            string repass = tbRepass.Text;

            MySqlConnection connection = new MySqlConnection(sqlConnection);
            if (password == repass)
            {
                string sql = "INSERT INTO users" +
                             "(user_name, user_email, user_pass)" +
                             "VALUES" +
                             "('"+username+"', '"+useremail+"', '"+password+"')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Form1_Load(null,null);
                
                tbUsername.Text = "";
                tbUseremail.Text = "";
                tbPassword.Text = "";
                tbRepass.Text = "";
            }
            else
            {
                MessageBox.Show("Mat khau khong dung");
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            lbUsername.Enabled = true;
            lbemail.Enabled = true;
            lbpassword.Enabled = true;
            lbrepass.Enabled = true;
      
            tbUsername.Enabled = true;
            tbUseremail.Enabled = true;
            tbPassword.Enabled = true;
            tbRepass.Enabled = true;

            string username = dgView.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
            string useremail = dgView.Rows[e.RowIndex].Cells["user_email"].Value.ToString();
            string id = dgView.Rows[e.RowIndex].Cells["user_id"].Value.ToString();

            tbUsername.Text = username;
            tbUseremail.Text = useremail;
            tbId.Text = id;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string useremail = tbUseremail.Text;
            string password = tbPassword.Text;
            string repass = tbRepass.Text;
            int id = int.Parse(tbId.Text);

            MySqlConnection connection = new MySqlConnection(sqlConnection);
            if (password == repass)
            {
                string sql = "UPDATE users SET " +
                             "user_name= '" + username + "', user_email = '" + useremail + "', user_pass= '" + password +
                             "' WHERE user_id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Form1_Load(null,null);

                tbId.Text = "";
                tbUsername.Text = "";
                tbUseremail.Text = "";
                tbPassword.Text = "";
                tbRepass.Text = "";
            }
            else
            {
                MessageBox.Show("Nhap mat khau sai");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);

            MySqlConnection connection = new MySqlConnection(sqlConnection);
           
                string sql = "DELETE FROM users WHERE user_id='"+ id +"'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Form1_Load(null,null);

                tbId.Text = "";
                tbUsername.Text = "";
                tbUseremail.Text = "";
                tbPassword.Text = "";
                tbRepass.Text = "";
        }
    }
}