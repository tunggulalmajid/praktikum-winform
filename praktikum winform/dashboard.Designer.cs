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
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 541);
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
    }
}