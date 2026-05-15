using praktikum_winform.Helpers;
using praktikum_winform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using praktikum_winform.Controllers;

namespace praktikum_winform
{
    public partial class dashboard : Form
    {

        UserController controller;
        private FormUtama _induk;

        public dashboard(FormUtama induk,string username)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            this._induk = induk;
            controller = new UserController();
            LoadData();
        }

        private void LoadData()
        {
            DgUser.DataSource = controller.GetAllUser();
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
                controller.DeleteUser(selected.id);
                LoadData();
            }
        }
    }
}
