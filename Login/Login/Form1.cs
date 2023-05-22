using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            SqlConnection conn =
            new SqlConnection(@"Data Source=DESKTOP-BNEUDTI\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

            try
            {
                string username = tbusername.Text, password = tbpassword.Text;
                string query = "SELECT * FROM login WHERE username = '" + username + "' AND password= '" + password + "'";
                SqlCommand sda = new SqlCommand(query, conn);
                SqlDataReader dta = sda.ExecuteReader();
                if (dta.Read()==true)
                {
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}