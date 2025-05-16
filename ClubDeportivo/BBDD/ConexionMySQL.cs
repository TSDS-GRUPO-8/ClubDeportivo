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
        private const string conexionBBDD = "server=localhost;database=club_deportivo;user=root;password=Passw0rd";

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(conexionBBDD);
            conexion.Open();
            return conexion;
        }
    }
}
