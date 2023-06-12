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


namespace DoAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string connect = "Server=localhost; user id=root; password= ; database=hotel";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                lbMesses.Visible = true;
                lbMessUser.Visible = false;
                lbMessPass.Visible = false;
            }
            else if (string.IsNullOrEmpty(username))
            {
                lbMesses.Visible = false;
                lbMessUser.Visible = true;
                lbMessPass.Visible = false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lbMesses.Visible = false;
                lbMessUser.Visible = false;
                lbMessPass.Visible = true;
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connect);
                string sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successfully Sign In!", "VINSMOKE MJ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Khai báo trang cần chuyển 
                    From2 otherForm = new From2();
                        
                    // Hiển thị form mới
                    otherForm.Show();
                        
                    // Ẩn form hiện tại (nếu cần)
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}