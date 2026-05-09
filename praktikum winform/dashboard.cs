using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_winform
{
    public partial class dashboard : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public dashboard(string username)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            LoadData();
        }

        private void LoadData()
        {
            DgUser.DataSource = db.GetAllUsers();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form3 formTambah = new Form3(null);
            formTambah.ShowDialog();
            LoadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            User selected = (User)DgUser.CurrentRow.DataBoundItem;
            Form3 formEdit = new Form3(selected);
            formEdit.ShowDialog();
            LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            User selected = (User)DgUser.CurrentRow.DataBoundItem;
            var Konfirmasi = MessageBox.Show(
                $"Hapus user `{selected.nama}`",
                "Konfirmasi", MessageBoxButtons.YesNo);
            if (Konfirmasi == DialogResult.Yes)
            {
                db.DeleteUser(selected.id);
                LoadData();
            }
        }
    }
}
