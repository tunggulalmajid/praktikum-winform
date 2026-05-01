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
    public partial class dashboard: Form
    {
        private List<User> listUser; 
        public dashboard(string username)
        {
            InitializeComponent();
            listUser = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                User user = new User($"Subar {i}", 20, "Muncar");
                listUser.Add(user);
            }
            LbDb.Text += username;
            DgUser.DataSource = listUser;
        }

        
    }
}
