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
        public bool NoSocioActivo { get; set; }

        public override bool EstadoActividad()
        {
            // Lógica para comprobar si el NoSocio se encuentra activo en alguna actividad
            return NoSocioActivo;
        }

        public void PagarActividad()
        {
            // Lógica para pagar la actividad
        }

        public void RegistrarNoSocio()
        {
            // Lógica para registrar un nuevo NoSocio
        }
    }
}
