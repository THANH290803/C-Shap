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

namespace DatabaseView
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void DataGridView_Load(object sender, EventArgs e)
    {
      
    }

    private string mySqlConnection = "server = localhost; user id = root; password = ; database = d05k13";
    private void Form1_Load(object sender, EventArgs e)
    {
      MySqlConnection connect = new MySqlConnection(mySqlConnection);
      string sql = "SELECT * FROM users";
      MySqlDataAdapter query = new MySqlDataAdapter(sql, connect);
      DataSet item = new DataSet();
      query.Fill(item, "users");
      dgvUser.DataSource = item.Tables["users"].DefaultView;
    }
  }
}
