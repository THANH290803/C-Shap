using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DoAn
{
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            
        }

        private string connect = "server = localhost; user id= root; password= ; database= hotel";
        
        private void BookManager_Load_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT books.bk_id, books.bk_name, books.bk_img, books.bk_amount, books.bk_price, books.bk_content, theloai.tl_name " +
                         "FROM books INNER JOIN theloai ON books.id_tl = theloai.id_tl ORDER BY books.bk_name ASC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            adapter.Fill(item, "books");
            dataGridView1.DataSource = item.Tables["books"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void getTL()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM theloai";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            cbTL.DataSource = item;

            cbTL.DisplayMember = "tl_name";

            cbTL.ValueMember = "id_tl";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            lbimg.Enabled = true;
            label9.Enabled = true;

            tbName.Enabled = true;
            tbAmount.Enabled = true;
            tbImage.Enabled = true;
            tbContent.Enabled = true;
            tbPrice.Enabled = true;
            cbTL.Enabled = true;
            getTL();

            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            tbName.Text = "";
            tbPrice.Text = "";
            tbAmount.Text = "";
            tbContent.Text = "";
            tbImage.Text = "";
            cbTL.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string price = tbPrice.Text;
            int amount = int.Parse(tbAmount.Text);
            string noidung = tbContent.Text;
            string img = tbImage.Text;
            string tl = cbTL.SelectedValue.ToString();
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "INSERT INTO books (bk_name, bk_img, bk_amount, bk_price, bk_content, id_tl) VALUES " +
                           "('"+name+"', '"+img+"', "+amount+", '"+price+"', '"+noidung+"',"+tl+")";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            connection.Close();
            BookManager_Load_1(null,null);

            tbName.Text = "";
            tbPrice.Text = "";
            tbAmount.Text = "";
            tbContent.Text = "";
            tbImage.Text = "";
            cbTL.ResetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text;
            
            DataView dataView = (DataView)dataGridView1.DataSource;
            string filter = string.Format("bk_name LIKE '%{0}%'", searchText);
            dataView.RowFilter = filter;
            dataGridView1.DataSource = dataView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            lbimg.Enabled = true;
            label9.Enabled = true;

            tbName.Enabled = true;
            tbAmount.Enabled = true;
            tbImage.Enabled = true;
            tbContent.Enabled = true;
            tbPrice.Enabled = true;
            cbTL.Enabled = true;
            
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;

            string tl_name = dataGridView1.Rows[e.RowIndex].Cells["tl_name"].Value.ToString();
            string id = dataGridView1.Rows[e.RowIndex].Cells["bk_id"].Value.ToString();
            string bkName = dataGridView1.Rows[e.RowIndex].Cells["bk_name"].Value.ToString();
            string bkImage = dataGridView1.Rows[e.RowIndex].Cells["bk_img"].Value.ToString();
            string bkAmount = dataGridView1.Rows[e.RowIndex].Cells["bk_amount"].Value.ToString();
            string bkPrice = dataGridView1.Rows[e.RowIndex].Cells["bk_price"].Value.ToString();
            string bkContent = dataGridView1.Rows[e.RowIndex].Cells["bk_content"].Value.ToString();

            tbName.Text = bkName;
            tbPrice.Text = bkPrice;
            tbImage.Text = bkImage;
            tbAmount.Text = bkAmount;
            tbContent.Text = bkContent;
            tbBkId.Text = id;
            getTL();

            int index = cbTL.FindStringExact(tl_name);
            if (index != -1)
            {
                cbTL.SelectedIndex = index;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string price = tbPrice.Text;
            int amount = int.Parse(tbAmount.Text);
            string noidung = tbContent.Text;
            string img = tbImage.Text;
            int id = Int32.Parse(tbBkId.Text);
            string tl = cbTL.SelectedValue.ToString();

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "UPDATE books SET " +
                         "bk_name= '" + name + "', bk_img = '" + img + "', bk_amount= '" + amount + "', bk_price= '" + price + "', 	bk_content= '" + noidung +"', id_tl= '" + tl +
                         "' WHERE bk_id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BookManager_Load_1(null,null);
            
            tbName.Text = "";
            tbPrice.Text = "";
            tbAmount.Text = "";
            tbContent.Text = "";
            tbImage.Text = "";
            cbTL.ResetText();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbBkId.Text);

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "DELETE FROM books WHERE bk_id='" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BookManager_Load_1(null, null);
            
            tbName.Text = "";
            tbPrice.Text = "";
            tbAmount.Text = "";
            tbContent.Text = "";
            tbImage.Text = "";
            cbTL.ResetText();

        }
    }
}