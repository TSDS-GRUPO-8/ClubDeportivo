using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class NoSocio : Persona
    {

        public int IdNoSocio { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public List <Actividad> Actividades { get; set; }
        // contadores ESTATICOS, todos los socios comparten el mismo contador
        private static int contadorNoSocios = 1;
        public NoSocio(DateTime fechaInscripcion, string nombre, string apellido, string dni, string nroTelefono, string direccion)
        {
            IdNoSocio = contadorNoSocios++;
            FechaInscripcion = fechaInscripcion;
            Actividades = new List<Actividad>(); // SIEMPRE arranca vacía
            Activo = false; // No está en ninguna actividad aún

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NroTelefono = nroTelefono;
            Direccion = direccion;
        }
        public override bool EstadoActividad()
        {
            // Lógica para comprobar si el NoSocio se encuentra activo en alguna actividad
            return Activo;
        }

        public void PagarActividad()
        {
            // Lógica para pagar la actividad
        }
    }
}
