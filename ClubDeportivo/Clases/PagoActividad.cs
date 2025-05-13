using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class PagoActividad
    {
        public int IdPagoActividad { get; set; }
        public bool EstadoDelPago { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public bool ValidarAcceso()
        {
            // Lógica para validar acceso a actividad
            return EstadoDelPago && FechaVencimiento > DateTime.Now;
        }
    }
}
