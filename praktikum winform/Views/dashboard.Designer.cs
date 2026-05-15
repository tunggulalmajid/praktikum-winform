namespace praktikum_winform
{
    partial class dashboard
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
            LbDb = new Label();
            DgUser = new DataGridView();
            btnTambah = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // LbDb
            // 
            LbDb.AutoSize = true;
            LbDb.Font = new Font("Segoe UI", 25F);
            LbDb.Location = new Point(31, 65);
            LbDb.Name = "LbDb";
            LbDb.Size = new Size(273, 46);
            LbDb.TabIndex = 0;
            LbDb.Text = "Selamat Datang, ";
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(31, 243);
            DgUser.Name = "DgUser";
            DgUser.Size = new Size(408, 244);
            DgUser.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.MediumSeaGreen;
            btnTambah.Location = new Point(202, 214);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.ActiveCaption;
            BtnUpdate.Location = new Point(283, 214);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 3;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.IndianRed;
            BtnDelete.Location = new Point(364, 214);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 541);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(btnTambah);
            Controls.Add(DgUser);
            Controls.Add(LbDb);
            Name = "dashboard";
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbDb;
        private DataGridView DgUser;
        private Button btnTambah;
        private Button BtnUpdate;
        private Button BtnDelete;
    }
}