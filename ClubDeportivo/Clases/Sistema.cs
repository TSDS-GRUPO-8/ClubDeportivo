using System;
using System.Collections.Generic;
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

        public void RegistrarNoSocio(string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaInscripcion)
        {
            var noSocioExistente = noSocios.Find(ns => ns.Dni == dni);
            if (noSocioExistente == null)
            {
                noSocios.Add(new NoSocio
                (fechaInscripcion, nombre, apellido, dni, telefono, direccion));

                Console.WriteLine($"{nombre} registrado correctamente.");
            }
            else
            {
                Console.WriteLine("Ya existe un no socio registrado con ese DNI.");
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
        public void PagarCuota(string dni)
        {
            // Caso 1: la persona está en NoSocios → se convierte en socio
            var noSocio = noSocios.FirstOrDefault(ns => ns.Dni == dni);
            if (noSocio != null)
            {
                Socio nuevoSocio = new Socio(
                    fechaInscripcion: DateTime.Now,
                    nombre: noSocio.Nombre,
                    apellido: noSocio.Apellido,
                    dni: noSocio.Dni,
                    nroTelefono: noSocio.NroTelefono,
                    direccion: noSocio.Direccion
                );

                socios.Add(nuevoSocio);
                noSocios.Remove(noSocio);

                Console.WriteLine($"Alta de socio realizada. {nuevoSocio.Nombre} es ahora un socio activo.");
                return;
            }

            // Caso 2: la persona ya es socio → registrar pago de cuota mensual
            var socio = socios.FirstOrDefault(s => s.Dni == dni);
            if (socio != null)
            {
                socio.FechaUltimoPago = DateTime.Now; // Asumimos que agregás esta propiedad
                Console.WriteLine($"Pago de cuota registrado para {socio.Nombre}.");
                return;
            }

            // Caso 3: no se encontró
            Console.WriteLine("No se encontró un no socio ni un socio con ese DNI.");
        }
        public bool VerificarAcceso(string usuario, string contraseña)
        {
            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "admin";

            return usuario == usuarioCorrecto && contraseña == contraseñaCorrecta;
        }
    }
}