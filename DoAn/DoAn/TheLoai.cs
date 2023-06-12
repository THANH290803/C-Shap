using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DoAn
{
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookManager other = new BookManager();
            other.Show();
            this.Hide();
        }
        
        private string connect = "server = localhost; user id= root; password= ; database= hotel";

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text;
            
            DataView dataView = (DataView)dgvTL.DataSource;
            string filter = string.Format("tl_name LIKE '%{0}%'", searchText);
            dataView.RowFilter = filter;
            dgvTL.DataSource = dataView;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            lbTenTL.Enabled = true;

            tbNameTl.Enabled = true;

            btnSAVEtl.Enabled = true;
            btnEditTL.Enabled = false;
            BtnXoa.Enabled = false;

            tbNameTl.Text = "";
            
        }


        private void btnSAVEtl_Click(object sender, EventArgs e)
        {
            string tl_name = tbNameTl.Text;
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "INSERT INTO theloai" +
                         "(tl_name)" +
                         "VALUES" +
                         "('"+tl_name+"')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            TheLoai_Load(null,null);

            tbNameTl.Text = "";
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM theloai";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            adapter.Fill(item, "theloai");
            dgvTL.DataSource = item.Tables["theloai"].DefaultView;
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTenTL.Enabled = true;

            tbNameTl.Enabled = true;

            btnSAVEtl.Enabled = false;
            btnEditTL.Enabled = true;
            BtnXoa.Enabled = true;

            string id = dgvTL.Rows[e.RowIndex].Cells["id_tl"].Value.ToString();
            string name = dgvTL.Rows[e.RowIndex].Cells["tl_name"].Value.ToString();

            tbID.Text = id;
            tbNameTl.Text = name;
            
        }


        private void btnEditTL_Click(object sender, EventArgs e)
        {
            string name = tbNameTl.Text;
            int id = Int32.Parse(tbID.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "UPDATE theloai SET " +
                         "tl_name= '" + name +
                         "' WHERE id_tl = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            TheLoai_Load(null,null);
            
            tbNameTl.Text = "";
            tbID.Text = "";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbID.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "DELETE FROM theloai WHERE id_tl= '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            TheLoai_Load(null,null);
            
            tbNameTl.Text = "";
            tbID.Text = "";
        }
    }
}