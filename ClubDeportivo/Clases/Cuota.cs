using System;

namespace ClubDeportivo.Clases
{
    public class Cuota
    {
        public int IdCuota { get; set; }                   // Identificador único de la cuota
        public int IdSocio { get; set; }                   // ID del socio que paga
        public bool EstadoDelPago { get; set; }            // true si está pagada
        public string FormaPago { get; set; }              // Efectivo, Tarjeta, Débito, etc.
        public DateTime FechaPago { get; set; }            // Fecha en que se realiza el pago
        public DateTime FechaVencimiento { get; set; }     // Fecha límite para pagar
        public decimal Monto { get; set; }                 // Monto pagado

        // Constructor principal
        public Cuota(int idCuota, int idSocio, bool estadoDelPago, string formaPago, DateTime fechaPago, DateTime fechaVencimiento, decimal monto)
        {
            IdCuota = idCuota;
            IdSocio = idSocio;
            EstadoDelPago = estadoDelPago;
            FormaPago = formaPago;
            FechaPago = fechaPago;
            FechaVencimiento = fechaVencimiento;
            Monto = monto;
        }

        // Constructor sin ID (por ejemplo, si lo autogenera la base de datos)
        public Cuota(int idSocio, string formaPago, DateTime fechaPago, DateTime fechaVencimiento, decimal monto)
        {
            EstadoDelPago = true; // Se considera pagada al crearla
            IdSocio = idSocio;
            FormaPago = formaPago;
            FechaPago = fechaPago;
            FechaVencimiento = fechaVencimiento;
            Monto = monto;
        }

        // Verifica si tiene acceso a actividades (pago vigente y sin vencimiento)
        public bool ValidarAcceso()
        {
            return EstadoDelPago && FechaVencimiento >= DateTime.Now;
        }

        // Verifica si está vencida
        public bool EstaVencida()
        {
            return FechaVencimiento < DateTime.Now;
        }

        // Opcional: mostrar resumen
        public override string ToString()
        {
            return $"Cuota #{IdCuota} - Monto: ${Monto} - Pago: {FechaPago.ToShortDateString()} - Vence: {FechaVencimiento.ToShortDateString()} - Forma: {FormaPago}";
        }
    }
}
