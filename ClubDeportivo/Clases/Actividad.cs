using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class Actividad
    {
        private static int contadorActividades = 1;
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Horario { get; set; }
        public List<string> Profesor { get; set; }
        public decimal Precio { get; set; }
        public DateTime DiaYHora { get; set; }


        public Actividad(string nombre, TimeSpan horario, List<string> profesor, decimal precio, DateTime diaYHora)
        {
            IdActividad = contadorActividades++;
            Nombre = nombre;
            Horario = horario;
            Profesor = profesor ?? new List<string>(); // Si no pasan lista, creamos una vacía
            Precio = precio;
            DiaYHora = diaYHora;
        }
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
