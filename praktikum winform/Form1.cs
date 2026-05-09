using System.Drawing.Drawing2D;

namespace praktikum_winform
{
    public partial class Login : Form
    {
        private FormUtama _induk;
        private string username;
        private string password;
        public Login(FormUtama induk)
        {
            InitializeComponent();
            username = "tunggul";
            password = "tunggul";
            this._induk = induk;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 30;

            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, panel1.Width, panel1.Height);

            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = TbUsername.Text;
            string userPassword = TbPassword.Text;

            if (userInput == username && userPassword == password)
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _induk.BukaFormDiPanel(new dashboard(this._induk, userInput));
            }
            else
            {
                MessageBox.Show("Login Gagal", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
