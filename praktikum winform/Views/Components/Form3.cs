using praktikum_winform.Controllers;
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

namespace praktikum_winform
{
    public partial class Form3 : Form
    {
        private User _user;
        UserController controller;

        public Form3(User user)
        {
            InitializeComponent();
            _user = user;


            if (_user != null)
            {
                txtNama.Text = _user.nama;
                txtUmur.Text = _user.umur.ToString();
                txtAsal.Text = _user.asal;
            }
            controller = new UserController();
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_user == null) // TAMBAH
            {
                User baru = new User(0, txtNama.Text, int.Parse(txtUmur.Text), txtAsal.Text);
                controller.AddUser(baru);
                MessageBox.Show("User berhasil ditambahkan!");
            }
            else // EDIT
            {
                _user.nama = txtNama.Text;
                _user.umur = int.Parse(txtUmur.Text);
                _user.asal = txtAsal.Text;
                controller.UpdateUser(_user);
                MessageBox.Show("User berhasil diupdate!");
            }


            this.Close();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
