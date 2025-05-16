using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool FichaMedica { get; set; }
        public bool Activo { get; set; }

        // Método abstracto para determinar si la persona esta Activa (cuota al dia o actividad activa)
        public abstract bool EstadoActividad();
    }
}
