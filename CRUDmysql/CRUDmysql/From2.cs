using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUDmysql
{
    public partial class From2 : Form
    {
        public From2()
        {
            InitializeComponent();
        }

        private void From2_Load(object sender, EventArgs e)
        {
            
        }

        private string connect = "server = localhost; user id = root; password = ; database = d05k13";

        private void From2_Load_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM category";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            adapter.Fill(item, "category");
            dgvCat.DataSource = item.Tables["category"].DefaultView;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            lbCat.Enabled = true;
            tbCat.Enabled = true;

            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nameCat = tbCat.Text;

            MySqlConnection connection = new MySqlConnection(connect);
            
            string sql = "INSERT INTO category" +
                         "(cat_name)" +
                         "VALUES" +
                         "('"+nameCat+"')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null,null);

            tbCat.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nameCat = tbCat.Text;
            int id = int.Parse(tbId.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            
            string sql = "UPDATE category SET " +
                         "cat_name= '" + nameCat +
                         "' WHERE cat_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null,null);

            tbCat.Text = "";
            tbId.Text = "";
        }

        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCat.Enabled = true;
            tbCat.Enabled = true;
            
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            string nameCat = dgvCat.Rows[e.RowIndex].Cells["cat_name"].Value.ToString();
            string id = dgvCat.Rows[e.RowIndex].Cells["cat_id"].Value.ToString();

            tbCat.Text = nameCat;
            tbId.Text = id;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            
            string sql = "DELETE FROM category WHERE cat_id='"+ id +"'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null, null);

            tbId.Text = "";
            tbCat.Text = "";
        }
    }
}