using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.BBDD
{
    public class ConexionMySQL
    {
        private static readonly string connectionString =
            "Server=mysql-unknowteam.alwaysdata.net;" +
            "Database=unknowteam_club_deportivo;" +
            "User ID=413567;" +
            "Password=administrador;" +
            "Port=3306;" +
            "SslMode=None;";

        public static MySqlConnection ObtenerConexion()
        {
            var conexion = new MySqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
