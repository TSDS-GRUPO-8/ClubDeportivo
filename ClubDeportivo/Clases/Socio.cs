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

        public override bool EstadoActividad()
        {
            // Lógica para comprobar si el socio está activo
            return Activo;
        }

        public void EntregarCarnet()
        {
            // Lógica para entregar el carnet al socio
        }

        public void PagarCuota()
        {
            // Lógica para pagar la cuota
        }

        public void RegistrarSocio()
        {
            // Lógica para registrar un nuevo socio
        }

        public bool Deuda()
        {
            // Lógica para verificar si el socio tiene deudas
            return false;
        }
    }
}
