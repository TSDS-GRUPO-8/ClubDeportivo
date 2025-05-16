using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class NoSocio : Persona
    {
        // contador ESTATICO
        private static int contadorNoSocios = 1;

        public int IdNoSocio { get; set; }
        public List <Actividad> Actividades { get; set; }

        public NoSocio(DateTime fechaInscripcion, string nombre, string apellido, string dni, string nroTelefono, string direccion, bool fichaMedica)
        {
            IdNoSocio = contadorNoSocios++;
            FechaInscripcion = fechaInscripcion;
            Actividades = new List<Actividad>(); // SIEMPRE arranca vacía
            Activo = false; // No está en ninguna actividad aún
            FichaMedica = fichaMedica;

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = nroTelefono;
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
