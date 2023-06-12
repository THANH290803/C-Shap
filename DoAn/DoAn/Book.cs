using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DoAn
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            From2 other = new From2();
            
            other.Show();
            this.Hide();
        }

        private string connect = "server = localhost; user id= root; password= ; database= hotel";

        private void Book_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT books.bk_name, books.bk_img FROM books";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet item = new DataSet();
            adapter.Fill(item, "books");
            dgvView.DataSource = item.Tables["books"].DefaultView;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text;
            
            DataView dataView = (DataView)dgvView.DataSource;
            string filter = string.Format("bk_name LIKE '%{0}%'", searchText);
            dataView.RowFilter = filter;
            dgvView.DataSource = dataView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookManager bookManager = new BookManager();
            bookManager.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
            this.Hide();
        }
    }
}