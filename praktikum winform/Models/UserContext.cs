using Npgsql;
using praktikum_winform.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_winform.Models
{
    class UserContext
    {
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                ));
            }
            return list;
        }

        public void AddUser(User user)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUser(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM users WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }

    }
}
