using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using praktikum_winform.Models;

namespace praktikum_winform.Helpers
{
     class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=winforms_db;Username=postgres;Password=admin123";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
