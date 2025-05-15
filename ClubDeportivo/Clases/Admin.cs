using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Admin : Persona
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        // Estas listas SON ESTATICAS: todos los Admins comparten la misma
        public static List<Socio> socios = new List<Socio>();
        public static List<NoSocio> noSocios = new List<NoSocio>();
        public static List<Actividad> actividades = new List<Actividad>();

        public Admin()
        {
            Nombre = "Administrador";
            Apellido = "Admin";
            Dni = "00000000";
            NroTelefono = "0000000000";
            Direccion = "Club Deportivo";
            Usuario = "admin";
            Contraseña = "admin";
        }
        public Admin(string nombre, string apellido, string dni, string nroTelefono, string direccion,
                     string usuario, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NroTelefono = nroTelefono;
            Direccion = direccion;
            Usuario = usuario;
            Contraseña = contraseña;
        }

        private static int ultimoCarnet = 1000;

        private static int GenerarCarnetNuevo()
        {
            ultimoCarnet++;
            return ultimoCarnet;
        }
        public void RegistrarSocio(string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaInscripcion)
        {
            // Primero verificamos si ya existe un socio con el mismo DNI
            var socioExistente = socios.Find(s => s.Dni == dni);

            if (socioExistente == null)
            {
                socios.Add(new Socio
                (fechaInscripcion, nombre, apellido, dni, telefono, direccion));

                Console.WriteLine($"Socio {nombre} registrado correctamente.");
            }
            else
            {
                Console.WriteLine("Ya existe un socio registrado con ese DNI.");
            }
        }
        public void RegistrarNoSocio(string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaInscripcion)
        {
            var noSocioExistente = noSocios.Find(ns => ns.Dni == dni);

            if (noSocioExistente == null)
            {
                noSocios.Add(new NoSocio
                (fechaInscripcion, nombre, apellido, dni, telefono, direccion));

                Console.WriteLine($"No Socio {nombre} registrado correctamente.");
            }
            else
            {
                Console.WriteLine("Ya existe un no socio registrado con ese DNI.");
            }
        }
        public void RegistrarActividad(int idActividad, string nombreActividad, TimeSpan horario, List<string> profesores, decimal precio, DateTime diaYHora)
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
        public override bool EstadoActividad()
        {
            // El admin siempre está "activo"
            return true;
        }

        public bool VerificarAcceso(string usuarioIngresado, string contraseñaIngresada)
        {
            return Usuario == usuarioIngresado && Contraseña == contraseñaIngresada;
        }
    }
}

// Admin administrador = new Admin(
//    nombre: "Administrador",
//    apellido: "admin",
//    dni: "12345678",
//    nroTelefono: "3411234567",
//    direccion: "Av. Siempreviva 742",
//    usuario: "admin",
//    contraseña: "admin"
//);