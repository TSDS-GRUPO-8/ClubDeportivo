using ClubDeportivo.BBDD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Sistema
    {
        public static List<Socio> socios = new List<Socio>();
        public static List<NoSocio> noSocios = new List<NoSocio>();
        public static List<Actividad> actividades = new List<Actividad>();

        public void RegistrarNoSocio(NoSocio nuevoNoSocio)
        {
            using (var con = ConexionMySQL.ObtenerConexion())
            {
                // 1. Verificar si ya existe
                string consulta = "SELECT COUNT(*) FROM no_socios WHERE dni = @dni";
                var cmdVerificacion = new MySqlCommand(consulta, con);
                cmdVerificacion.Parameters.AddWithValue("@dni", nuevoNoSocio.Dni);
                long existe = (long)cmdVerificacion.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("Ya existe un NoSocio con ese DNI.");
                    return;
                }

                // 2. Insertar si no existe
                string sql = @"INSERT INTO no_socios 
        (nombre, apellido, dni, telefono, direccion, fecha_inscripcion, activo, ficha_medica)
        VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @fecha, @activo, @fichaMedica)";

                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", nuevoNoSocio.Nombre);
                cmd.Parameters.AddWithValue("@apellido", nuevoNoSocio.Apellido);
                cmd.Parameters.AddWithValue("@dni", nuevoNoSocio.Dni);
                cmd.Parameters.AddWithValue("@telefono", nuevoNoSocio.Telefono);
                cmd.Parameters.AddWithValue("@direccion", nuevoNoSocio.Direccion);
                cmd.Parameters.AddWithValue("@fecha", nuevoNoSocio.FechaInscripcion);
                cmd.Parameters.AddWithValue("@activo", nuevoNoSocio.Activo);
                cmd.Parameters.AddWithValue("@fichaMedica", nuevoNoSocio.FichaMedica);

                cmd.ExecuteNonQuery();

                MessageBox.Show("¡No Socio registrado correctamente en la base de datos!");
            }
        }

        public void RegistrarActividad(string nombreActividad, TimeSpan horario, List<string> profesores, decimal precio, DateTime diaYHora)
        {
            var actividadExistente = actividades.Find(a => a.Nombre.Equals(nombreActividad, StringComparison.OrdinalIgnoreCase));

            if (actividadExistente == null)
            {
                actividades.Add(new Actividad
                (nombreActividad, horario, profesores, precio, diaYHora));

                Console.WriteLine($"Actividad {nombreActividad} registrada correctamente.");
            }
            else
            {
                Console.WriteLine("La actividad ya existe.");
            }
        }
        public string PagarCuota(string dni)
        {
            using (var con = ConexionMySQL.ObtenerConexion())
            {
                // Buscar en NoSocios
                string queryBuscarNoSocio = "SELECT * FROM no_socios WHERE dni = @dni";
                var cmdBuscarNoSocio = new MySqlCommand(queryBuscarNoSocio, con);
                cmdBuscarNoSocio.Parameters.AddWithValue("@dni", dni);

                using (var reader = cmdBuscarNoSocio.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // ←–– leer datos del no socio
                        string nombre = reader.GetString("nombre");
                        string apellido = reader.GetString("apellido");
                        string telefono = reader.GetString("telefono");
                        string direccion = reader.GetString("direccion");
                        bool fichaMedica = reader.GetBoolean("ficha_medica");
                        DateTime fechaInscripcion = DateTime.Now;

                        reader.Close(); // cerrar reader antes de usar otra consulta en la misma conexión

                        // ←–– insertar nuevo socio
                        string insertSocio = @"
                    INSERT INTO socios (nombre, apellido, dni, telefono, direccion, fecha_inscripcion, ficha_medica, activo, carnet)
                    VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @fecha, @fichaMedica, @activo, @carnet)";

                        var cmdInsertSocio = new MySqlCommand(insertSocio, con);
                        cmdInsertSocio.Parameters.AddWithValue("@nombre", nombre);
                        cmdInsertSocio.Parameters.AddWithValue("@apellido", apellido);
                        cmdInsertSocio.Parameters.AddWithValue("@dni", dni);
                        cmdInsertSocio.Parameters.AddWithValue("@telefono", telefono);
                        cmdInsertSocio.Parameters.AddWithValue("@direccion", direccion);
                        cmdInsertSocio.Parameters.AddWithValue("@fecha", fechaInscripcion);
                        cmdInsertSocio.Parameters.AddWithValue("@fichaMedica", fichaMedica);
                        cmdInsertSocio.Parameters.AddWithValue("@activo", true);
                        cmdInsertSocio.Parameters.AddWithValue("@carnet", true);

                        cmdInsertSocio.ExecuteNonQuery();

                        // ←–– eliminar el no socio
                        string deleteNoSocio = "DELETE FROM no_socios WHERE dni = @dni";
                        var cmdDelete = new MySqlCommand(deleteNoSocio, con);
                        cmdDelete.Parameters.AddWithValue("@dni", dni);
                        cmdDelete.ExecuteNonQuery();

                        return "¡Alta como Socio registrada con éxito!";
                    }
                }

                // Si ya es socio
                string queryBuscarSocio = "SELECT idSocio FROM socios WHERE dni = @dni";
                var cmdBuscarSocio = new MySqlCommand(queryBuscarSocio, con);
                cmdBuscarSocio.Parameters.AddWithValue("@dni", dni);

                object result = cmdBuscarSocio.ExecuteScalar();
                if (result != null)
                {
                    int idSocio = Convert.ToInt32(result);
                    DateTime fechaPago = DateTime.Now;
                    DateTime fechaVencimiento = fechaPago.AddMonths(1);

                    string insertCuota = @"
                INSERT INTO cuotas (idSocio, estadoDelPago, fechaPago, fechaVencimiento)
                VALUES (@idSocio, @pagado, @fechaPago, @fechaVencimiento)";
                    var cmdCuota = new MySqlCommand(insertCuota, con);
                    cmdCuota.Parameters.AddWithValue("@idSocio", idSocio);
                    cmdCuota.Parameters.AddWithValue("@pagado", true);
                    cmdCuota.Parameters.AddWithValue("@fechaPago", fechaPago);
                    cmdCuota.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);

                    cmdCuota.ExecuteNonQuery();

                    return "¡Cuota mensual registrada con éxito!";
                }

                // Si no se encontró en ninguna tabla
                return "No se encontró ningún socio o no socio con ese DNI.";
            }
        }


        public bool VerificarAcceso(string usuario, string contraseña)
        {
            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "admin";

            return usuario == usuarioCorrecto && contraseña == contraseñaCorrecta;
        }
    }
}