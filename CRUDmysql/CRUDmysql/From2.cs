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
            // PRODUCT VS CATEGORY
            string sqlProduct = "SELECT p.prd_id, p.prd_name, p.prd_price, p.prd_details, c.cat_name FROM product p INNER JOIN category c ON p.cat_id = c.cat_id ORDER BY p.prd_id ASC";
            MySqlDataAdapter query = new MySqlDataAdapter(sqlProduct, connection);
            DataTable itemPrd = new DataTable();
            query.Fill(itemPrd);
            dgvPrd.DataSource = itemPrd;

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

        private void getCategorise()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM category";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            comboBox1.DataSource = item;

            comboBox1.DisplayMember = "cat_name";

            comboBox1.ValueMember = "cat_id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbNamePrd.Enabled = true;
            lbpricePrd.Enabled = true;
            lbMota.Enabled = true;
            lbDanhmuc.Enabled = true;

            tbNamePrd.Enabled = true;
            tbprice.Enabled = true;
            tbMoTa.Enabled = true;
            comboBox1.Enabled = true;
            
            btnSavePrd.Enabled = true;
            btnEditPrd.Enabled = false;
            btnDelPrd.Enabled = false;
            // dgvPrd.CellClick -= dgvPrd_CellClick;
            // dgvPrd.Enabled = false;
            getCategorise();
            
            tbNamePrd.Text = "";
            tbprice.Text = "";
            tbMoTa.Text = "";
            tbPrdId.Text = "";
            comboBox1.ResetText();

        }

        private void btnSavePrd_Click(object sender, EventArgs e)
        {
            string name = tbNamePrd.Text;
            string price = tbprice.Text;
            string mota = tbMoTa.Text;
            string category = comboBox1.SelectedValue.ToString();

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "INSERT INTO product" +
                         "(prd_name, prd_price, prd_details, cat_id)" +
                         "VALUES " +
                         "('"+name+"', "+price+", '"+mota+"', "+category+")";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null,null);
        }

        private void dgvPrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbNamePrd.Enabled = true;
            lbpricePrd.Enabled = true;
            lbMota.Enabled = true;
            lbDanhmuc.Enabled = true;

            tbNamePrd.Enabled = true;
            tbprice.Enabled = true;
            tbMoTa.Enabled = true;
            comboBox1.Enabled = true;
            
            btnSavePrd.Enabled = false;
            btnEditPrd.Enabled = true;
            btnDelPrd.Enabled = true;
            
            
            string catName = dgvPrd.Rows[e.RowIndex].Cells["cat_name"].Value.ToString();
            string id = dgvPrd.Rows[e.RowIndex].Cells["prd_id"].Value.ToString();
            string prdName = dgvPrd.Rows[e.RowIndex].Cells["prd_name"].Value.ToString();
            string prdPrice = dgvPrd.Rows[e.RowIndex].Cells["prd_price"].Value.ToString();
            string prdDetail = dgvPrd.Rows[e.RowIndex].Cells["prd_details"].Value.ToString();

            tbNamePrd.Text = prdName;
            tbprice.Text = prdPrice;
            tbMoTa.Text = prdDetail;
            tbPrdId.Text = id;
            getCategorise();
            int index = comboBox1.FindStringExact(catName);
            if (index != -1)
            {
                comboBox1.SelectedIndex = index;
            }
        }

        private void btnEditPrd_Click(object sender, EventArgs e)
        {
            string namePrd = tbNamePrd.Text;
            string price = tbprice.Text;
            string mota = tbMoTa.Text;
            int id = int.Parse(tbPrdId.Text);
            string category = comboBox1.SelectedValue.ToString();

            MySqlConnection connection = new MySqlConnection(connect);
            
            string sql = "UPDATE product SET " +
                         "prd_name= '" + namePrd + "', prd_price = '" + price + "', prd_details= '" + mota + "', cat_id= '" + category +
                         "' WHERE prd_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null,null);

            tbNamePrd.Text = "";
            tbprice.Text = "";
            tbMoTa.Text = "";
            tbPrdId.Text = "";
            comboBox1.ResetText();
        }

        private void btnDelPrd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbPrdId.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            
            string sql = "DELETE FROM product WHERE prd_id='"+ id +"'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load_1(null, null);

            tbNamePrd.Text = "";
            tbprice.Text = "";
            tbMoTa.Text = "";
            tbPrdId.Text = "";
            comboBox1.ResetText();
        }
    }
}