using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Socio : Persona
    {
        // contadores ESTATICOS, todos los socios comparten el mismo contador
        private static int contadorSocios = 1;
        public int IdSocio { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Carnet { get; set; }
        public DateTime FechaUltimoPago { get; set; }

        public Socio(DateTime fechaInscripcion,
             string nombre, string apellido, string dni, string nroTelefono, string direccion)
        {
            IdSocio = contadorSocios++;
            FichaMedica = true;
            FechaInscripcion = fechaInscripcion;
            Carnet = true;
            Activo = true;

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NroTelefono = nroTelefono;
            Direccion = direccion;
        }

        public override bool EstadoActividad() => Activo;
        public void PagarCuota()
        {
            // Lógica para pagar la cuota
        }
        public bool Deuda()
        {
            // Lógica para verificar si el socio tiene deudas
            return false;
        }
    }
}
