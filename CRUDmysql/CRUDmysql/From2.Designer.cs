using System.ComponentModel;

namespace CRUDmysql
{
    partial class From2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.lbCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbPrdId = new System.Windows.Forms.TextBox();
            this.btnDelPrd = new System.Windows.Forms.Button();
            this.btnEditPrd = new System.Windows.Forms.Button();
            this.btnSavePrd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbNamePrd = new System.Windows.Forms.TextBox();
            this.lbMota = new System.Windows.Forms.Label();
            this.lbDanhmuc = new System.Windows.Forms.Label();
            this.lbpricePrd = new System.Windows.Forms.Label();
            this.lbNamePrd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrd = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1255, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.tbId);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnAddnew);
            this.tabPage1.Controls.Add(this.tbCat);
            this.tabPage1.Controls.Add(this.lbCat);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvCat);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1247, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(1017, 140);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(89, 22);
            this.tbId.TabIndex = 16;
            this.tbId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1018, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 63);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(813, 478);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 63);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1018, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 63);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddnew.FlatAppearance.BorderSize = 2;
            this.btnAddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnew.Location = new System.Drawing.Point(813, 367);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(147, 63);
            this.btnAddnew.TabIndex = 12;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // tbCat
            // 
            this.tbCat.Enabled = false;
            this.tbCat.Location = new System.Drawing.Point(779, 287);
            this.tbCat.Name = "tbCat";
            this.tbCat.Size = new System.Drawing.Size(417, 22);
            this.tbCat.TabIndex = 11;
            // 
            // lbCat
            // 
            this.lbCat.BackColor = System.Drawing.Color.Transparent;
            this.lbCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCat.Enabled = false;
            this.lbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCat.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCat.Location = new System.Drawing.Point(779, 225);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(145, 33);
            this.lbCat.TabIndex = 10;
            this.lbCat.Text = "Tên danh mục";
            this.lbCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCat
            // 
            this.dgvCat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCat.Location = new System.Drawing.Point(3, 3);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.RowTemplate.Height = 24;
            this.dgvCat.Size = new System.Drawing.Size(745, 729);
            this.dgvCat.TabIndex = 8;
            this.dgvCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.tbPrdId);
            this.tabPage2.Controls.Add(this.btnDelPrd);
            this.tabPage2.Controls.Add(this.btnEditPrd);
            this.tabPage2.Controls.Add(this.btnSavePrd);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.tbMoTa);
            this.tabPage2.Controls.Add(this.tbprice);
            this.tabPage2.Controls.Add(this.tbNamePrd);
            this.tabPage2.Controls.Add(this.lbMota);
            this.tabPage2.Controls.Add(this.lbDanhmuc);
            this.tabPage2.Controls.Add(this.lbpricePrd);
            this.tabPage2.Controls.Add(this.lbNamePrd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvPrd);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1247, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbPrdId
            // 
            this.tbPrdId.Location = new System.Drawing.Point(234, 78);
            this.tbPrdId.Name = "tbPrdId";
            this.tbPrdId.Size = new System.Drawing.Size(87, 22);
            this.tbPrdId.TabIndex = 15;
            this.tbPrdId.Visible = false;
            // 
            // btnDelPrd
            // 
            this.btnDelPrd.BackColor = System.Drawing.Color.Red;
            this.btnDelPrd.Enabled = false;
            this.btnDelPrd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPrd.Location = new System.Drawing.Point(987, 293);
            this.btnDelPrd.Name = "btnDelPrd";
            this.btnDelPrd.Size = new System.Drawing.Size(180, 48);
            this.btnDelPrd.TabIndex = 14;
            this.btnDelPrd.Text = "Delete";
            this.btnDelPrd.UseVisualStyleBackColor = false;
            this.btnDelPrd.Click += new System.EventHandler(this.btnDelPrd_Click);
            // 
            // btnEditPrd
            // 
            this.btnEditPrd.BackColor = System.Drawing.Color.Yellow;
            this.btnEditPrd.Enabled = false;
            this.btnEditPrd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEditPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPrd.Location = new System.Drawing.Point(683, 293);
            this.btnEditPrd.Name = "btnEditPrd";
            this.btnEditPrd.Size = new System.Drawing.Size(180, 48);
            this.btnEditPrd.TabIndex = 13;
            this.btnEditPrd.Text = "Edit";
            this.btnEditPrd.UseVisualStyleBackColor = false;
            this.btnEditPrd.Click += new System.EventHandler(this.btnEditPrd_Click);
            // 
            // btnSavePrd
            // 
            this.btnSavePrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSavePrd.Enabled = false;
            this.btnSavePrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrd.Location = new System.Drawing.Point(376, 293);
            this.btnSavePrd.Name = "btnSavePrd";
            this.btnSavePrd.Size = new System.Drawing.Size(180, 48);
            this.btnSavePrd.TabIndex = 12;
            this.btnSavePrd.Text = "Save";
            this.btnSavePrd.UseVisualStyleBackColor = false;
            this.btnSavePrd.Click += new System.EventHandler(this.btnSavePrd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(72, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(866, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // tbMoTa
            // 
            this.tbMoTa.Enabled = false;
            this.tbMoTa.Location = new System.Drawing.Point(866, 132);
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(254, 22);
            this.tbMoTa.TabIndex = 9;
            // 
            // tbprice
            // 
            this.tbprice.Enabled = false;
            this.tbprice.Location = new System.Drawing.Point(232, 191);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(254, 22);
            this.tbprice.TabIndex = 7;
            // 
            // tbNamePrd
            // 
            this.tbNamePrd.Enabled = false;
            this.tbNamePrd.Location = new System.Drawing.Point(232, 138);
            this.tbNamePrd.Name = "tbNamePrd";
            this.tbNamePrd.Size = new System.Drawing.Size(254, 22);
            this.tbNamePrd.TabIndex = 6;
            // 
            // lbMota
            // 
            this.lbMota.Enabled = false;
            this.lbMota.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbMota.Location = new System.Drawing.Point(757, 132);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(129, 22);
            this.lbMota.TabIndex = 5;
            this.lbMota.Text = "Mô tả";
            this.lbMota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDanhmuc
            // 
            this.lbDanhmuc.Enabled = false;
            this.lbDanhmuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhmuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDanhmuc.Location = new System.Drawing.Point(757, 188);
            this.lbDanhmuc.Name = "lbDanhmuc";
            this.lbDanhmuc.Size = new System.Drawing.Size(157, 25);
            this.lbDanhmuc.TabIndex = 4;
            this.lbDanhmuc.Text = "Danh mục";
            this.lbDanhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbpricePrd
            // 
            this.lbpricePrd.Enabled = false;
            this.lbpricePrd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpricePrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbpricePrd.Location = new System.Drawing.Point(96, 193);
            this.lbpricePrd.Name = "lbpricePrd";
            this.lbpricePrd.Size = new System.Drawing.Size(107, 18);
            this.lbpricePrd.TabIndex = 3;
            this.lbpricePrd.Text = "Giá sản phẩm";
            this.lbpricePrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNamePrd
            // 
            this.lbNamePrd.Enabled = false;
            this.lbNamePrd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNamePrd.Location = new System.Drawing.Point(96, 138);
            this.lbNamePrd.Name = "lbNamePrd";
            this.lbNamePrd.Size = new System.Drawing.Size(148, 22);
            this.lbNamePrd.TabIndex = 2;
            this.lbNamePrd.Text = "Tên sản phẩm";
            this.lbNamePrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1251, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản Phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrd
            // 
            this.dgvPrd.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPrd.GridColor = System.Drawing.Color.Cyan;
            this.dgvPrd.Location = new System.Drawing.Point(3, 419);
            this.dgvPrd.Name = "dgvPrd";
            this.dgvPrd.ReadOnly = true;
            this.dgvPrd.RowTemplate.Height = 24;
            this.dgvPrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrd.Size = new System.Drawing.Size(1241, 313);
            this.dgvPrd.TabIndex = 0;
            this.dgvPrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrd_CellClick);
            // 
            // From2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 764);
            this.Controls.Add(this.tabControl1);
            this.Name = "From2";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.From2_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbPrdId;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSavePrd;
        private System.Windows.Forms.Button btnEditPrd;
        private System.Windows.Forms.Button btnDelPrd;

        private System.Windows.Forms.Label lbpricePrd;
        private System.Windows.Forms.Label lbDanhmuc;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.TextBox tbNamePrd;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label lbNamePrd;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dgvPrd;

        private System.Windows.Forms.TextBox tbId;

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCat;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}