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

        public PagoActividad(int idPagoActividad, bool estadoDelPago, DateTime fechaPago, DateTime fechaVencimiento)
        {
            IdPagoActividad = idPagoActividad;
            EstadoDelPago = estadoDelPago;
            FechaPago = fechaPago;
            FechaVencimiento = fechaVencimiento;
        }
        public bool ValidarAcceso()
        {
            // Lógica para validar acceso a actividad
            return EstadoDelPago && FechaVencimiento > DateTime.Now;
        }
    }
}
