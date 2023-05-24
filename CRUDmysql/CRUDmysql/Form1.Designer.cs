namespace CRUDmysql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbRepass = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbUseremail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbrepass = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRepass
            // 
            this.tbRepass.Enabled = false;
            this.tbRepass.Location = new System.Drawing.Point(791, 157);
            this.tbRepass.Name = "tbRepass";
            this.tbRepass.Size = new System.Drawing.Size(266, 22);
            this.tbRepass.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(950, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Violet;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(671, 237);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 35);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(382, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Location = new System.Drawing.Point(92, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 35);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbUseremail
            // 
            this.tbUseremail.Enabled = false;
            this.tbUseremail.Location = new System.Drawing.Point(791, 92);
            this.tbUseremail.Name = "tbUseremail";
            this.tbUseremail.Size = new System.Drawing.Size(266, 22);
            this.tbUseremail.TabIndex = 21;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(179, 154);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(288, 22);
            this.tbPassword.TabIndex = 20;
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(179, 90);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(288, 22);
            this.tbUsername.TabIndex = 19;
            // 
            // lbrepass
            // 
            this.lbrepass.Enabled = false;
            this.lbrepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrepass.Location = new System.Drawing.Point(681, 157);
            this.lbrepass.Name = "lbrepass";
            this.lbrepass.Size = new System.Drawing.Size(113, 19);
            this.lbrepass.TabIndex = 18;
            this.lbrepass.Text = "Re-password";
            // 
            // lbemail
            // 
            this.lbemail.Enabled = false;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(681, 92);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(96, 23);
            this.lbemail.TabIndex = 17;
            this.lbemail.Text = "User email";
            // 
            // lbpassword
            // 
            this.lbpassword.Enabled = false;
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(63, 157);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(86, 19);
            this.lbpassword.TabIndex = 16;
            this.lbpassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.Enabled = false;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(65, 92);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(133, 20);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "User name";
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgView.Location = new System.Drawing.Point(0, 367);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(1128, 373);
            this.dgView.TabIndex = 14;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(179, 46);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 27;
            this.tbId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 740);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbRepass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbUseremail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbrepass);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.dgView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbId;

        private System.Windows.Forms.TextBox tbRepass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbUseremail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbrepass;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.DataGridView dgView;

        #endregion
    }
}