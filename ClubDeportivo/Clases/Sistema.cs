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
                // 1. Verificar si ya existe como SOCIO
                string querySocio = "SELECT COUNT(*) FROM socios WHERE dni = @dni";
                var cmdSocio = new MySqlCommand(querySocio, con);
                cmdSocio.Parameters.AddWithValue("@dni", nuevoNoSocio.Dni);
                long socioExiste = (long)cmdSocio.ExecuteScalar();

                if (socioExiste > 0)
                {
                    MessageBox.Show("Este DNI ya está registrado como SOCIO.");
                    return;
                }

                // 2. Verificar si ya existe como NO SOCIO
                string queryNoSocio = "SELECT COUNT(*) FROM no_socios WHERE dni = @dni";
                var cmdNoSocio = new MySqlCommand(queryNoSocio, con);
                cmdNoSocio.Parameters.AddWithValue("@dni", nuevoNoSocio.Dni);
                long noSocioExiste = (long)cmdNoSocio.ExecuteScalar();

                if (noSocioExiste > 0)
                {
                    MessageBox.Show("Este DNI ya está registrado como NO SOCIO.");
                    return;
                }

                // 3. Si no existe en ninguna tabla, se registra
                string insert = @"INSERT INTO no_socios 
        (nombre, apellido, dni, telefono, direccion, fecha_inscripcion, activo, ficha_medica)
        VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @fecha, @activo, @fichaMedica)";

                var cmdInsert = new MySqlCommand(insert, con);
                cmdInsert.Parameters.AddWithValue("@nombre", nuevoNoSocio.Nombre);
                cmdInsert.Parameters.AddWithValue("@apellido", nuevoNoSocio.Apellido);
                cmdInsert.Parameters.AddWithValue("@dni", nuevoNoSocio.Dni);
                cmdInsert.Parameters.AddWithValue("@telefono", nuevoNoSocio.Telefono);
                cmdInsert.Parameters.AddWithValue("@direccion", nuevoNoSocio.Direccion);
                cmdInsert.Parameters.AddWithValue("@fecha", nuevoNoSocio.FechaInscripcion);
                cmdInsert.Parameters.AddWithValue("@activo", nuevoNoSocio.Activo);
                cmdInsert.Parameters.AddWithValue("@fichaMedica", nuevoNoSocio.FichaMedica);

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Usuario registrado correctamente.");
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
        public string PagarCuota(string dni, decimal monto, string formaPago)
        {
            using (var con = ConexionMySQL.ObtenerConexion())
            {
                // 1. Buscar en no_socios - en caso de existir se da el alta en socios
                string queryNoSocio = "SELECT * FROM no_socios WHERE dni = @dni";
                var cmdBuscarNoSocio = new MySqlCommand(queryNoSocio, con);
                cmdBuscarNoSocio.Parameters.AddWithValue("@dni", dni);

                using (var reader = cmdBuscarNoSocio.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString("nombre");
                        string apellido = reader.GetString("apellido");
                        string telefono = reader.GetString("telefono");
                        string direccion = reader.GetString("direccion");
                        bool fichaMedica = reader.GetBoolean("ficha_medica");
                        DateTime fechaInscripcion = DateTime.Now;

                        reader.Close();

                        // Insertar en socios
                        string insertSocio = @"
                    INSERT INTO socios 
                    (nombre, apellido, dni, telefono, direccion, fecha_inscripcion, ficha_medica, activo, carnet)
                    VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @fecha, @fichaMedica, 1, 1)";
                        var cmdInsert = new MySqlCommand(insertSocio, con);
                        cmdInsert.Parameters.AddWithValue("@nombre", nombre);
                        cmdInsert.Parameters.AddWithValue("@apellido", apellido);
                        cmdInsert.Parameters.AddWithValue("@dni", dni);
                        cmdInsert.Parameters.AddWithValue("@telefono", telefono);
                        cmdInsert.Parameters.AddWithValue("@direccion", direccion);
                        cmdInsert.Parameters.AddWithValue("@fecha", fechaInscripcion);
                        cmdInsert.Parameters.AddWithValue("@fichaMedica", fichaMedica);
                        cmdInsert.ExecuteNonQuery();

                        // Eliminar de no_socios
                        string delete = "DELETE FROM no_socios WHERE dni = @dni";
                        var cmdDelete = new MySqlCommand(delete, con);
                        cmdDelete.Parameters.AddWithValue("@dni", dni);
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                // 2. Buscar usuario en la tabla Socios - Obtener idSocio
                string queryId = "SELECT idSocio FROM socios WHERE dni = @dni";
                var cmdId = new MySqlCommand(queryId, con);
                cmdId.Parameters.AddWithValue("@dni", dni);
                object result = cmdId.ExecuteScalar();

                if (result != null)
                {
                    int idSocio = Convert.ToInt32(result);
                    DateTime fechaPago = DateTime.Now;
                    DateTime fechaVencimiento = fechaPago.AddMonths(1);

                    // Buscar última fecha de vencimiento si existen cuotas pagas
                    string queryVenc = "SELECT MAX(fechaVencimiento) FROM cuotas WHERE idSocio = @idSocio";
                    var cmdVenc = new MySqlCommand(queryVenc, con);
                    cmdVenc.Parameters.AddWithValue("@idSocio", idSocio);
                    object vencResult = cmdVenc.ExecuteScalar();

                    if (vencResult != DBNull.Value && vencResult != null)
                    {
                        DateTime ultimaFechaVenc = Convert.ToDateTime(vencResult);
                        if (ultimaFechaVenc > fechaPago)
                        {
                            fechaVencimiento = ultimaFechaVenc.AddMonths(1);
                        }
                    }

                    // Insertar nueva cuota paga
                    string insertCuota = @"INSERT INTO cuotas (idSocio, estadoDelPago, formaPago, fechaPago, fechaVencimiento, monto)
                           VALUES (@idSocio, @estadoDelPago, @formaPago, @fechaPago, @fechaVencimiento, @monto)";
                    var cmdCuota = new MySqlCommand(insertCuota, con);
                    cmdCuota.Parameters.AddWithValue("@idSocio", idSocio);
                    cmdCuota.Parameters.AddWithValue("@estadoDelPago", true);
                    cmdCuota.Parameters.AddWithValue("@formaPago", formaPago);
                    cmdCuota.Parameters.AddWithValue("@fechaPago", fechaPago);
                    cmdCuota.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                    cmdCuota.Parameters.AddWithValue("@monto", monto);

                    cmdCuota.ExecuteNonQuery();

                    return "Cuota registrada correctamente.";
                }

                return "No se encontró un socio ni un no socio con ese DNI.";
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