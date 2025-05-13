using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Horario { get; set; }
        public List<string> Profesor { get; set; }
        public decimal Precio { get; set; }
        public DateTime DiaYHora { get; set; }

        public void ListarActividad()
        {
            // Lógica para listar actividades
        }

        public void AltaActividad()
        {
            // Lógica para dar de alta una actividad
        }

        public void BajaActividad()
        {
            // Lógica para dar de baja una actividad
        }
    }
}
