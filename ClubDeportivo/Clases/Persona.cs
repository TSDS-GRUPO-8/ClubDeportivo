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
        public string DNI { get; set; }
        public string NroTelefono { get; set; }
        public string Direccion { get; set; }

        // Método abstracto para determinar el estado de la actividad
        public abstract bool EstadoActividad();
    }
}
