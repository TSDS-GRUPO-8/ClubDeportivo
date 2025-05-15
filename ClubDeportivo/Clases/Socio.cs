using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int Carnet { get; set; }
        // contadores ESTATICOS, todos los socios comparten el mismo contador
        private static int contadorSocios = 1;
        private static int contadorCarnet = 1;


        public Socio(DateTime fechaInscripcion,
             string nombre, string apellido, string dni, string nroTelefono, string direccion)
        {
            IdSocio = contadorSocios++;
            FichaMedica = true;
            FechaInscripcion = fechaInscripcion;
            Carnet = contadorCarnet;
            Activo = false;

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NroTelefono = nroTelefono;
            Direccion = direccion;
        }

        public override bool EstadoActividad()
        {
            // Lógica para comprobar si el socio está activo
            return Activo;
        }
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
