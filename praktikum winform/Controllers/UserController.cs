using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using praktikum_winform.Models;

namespace praktikum_winform.Controllers
{
    class UserController
    {
        private UserContext context = new UserContext();

        public List<User> GetAllUser()
        {
            return context.GetAllUsers();
        }

        public void DeleteUser(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID user tidak valid");
            }

            context.DeleteUser(id);
        }

        public void AddUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.nama))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }

            context.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            context.UpdateUser(user);
        }

    }
}
