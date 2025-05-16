using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public int IdSocio { get; set; } // ID del socio al que pertenece la cuota
        public bool EstadoDelPago { get; set; }
        public string FormaPago { get; set; } // Efectivo, Tarjeta, Debito
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Cuota(int idCuota, bool estadoDelPago, DateTime fechaPago, DateTime fechaVencimiento)
        {
            IdCuota = idCuota;
            EstadoDelPago = estadoDelPago;
            FechaPago = fechaPago;
            FechaVencimiento = fechaVencimiento;
        }
        public bool ValidarAcceso()
        {
            // Comprueba si el pago está realizado y si la fecha de vencimiento es válida
            return EstadoDelPago && FechaVencimiento > DateTime.Now;
        }
    }
}
