using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace praktikum_winform
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            // Saat aplikasi jalan, langsung buka Form 1 (Login) ke dalam panel.
            // Kita mengirimkan 'this' (FormUtama) agar Form 1 mengenali siapa induknya.
            BukaFormDiPanel(new Login(this));
        }


        // Fungsi ajaib untuk mengganti isi panel
        public void BukaFormDiPanel(Form formAnak)
        {
            if (this.panelUtama.Controls.Count > 0)
            {
                this.panelUtama.Controls[0].Dispose(); // Bersihkan form sebelumnya
                this.panelUtama.Controls.Clear();
            }


            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            this.panelUtama.Controls.Add(formAnak);
            this.panelUtama.Tag = formAnak;
            formAnak.Show();
        }
    }
}
