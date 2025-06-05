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
        public List<DiaYHorario> Dias { get; set; }
        public List<Profesor> Profesores { get; set; }  // Cuando implementes la clase Profesor
        public decimal Precio { get; set; }

        public Actividad(string nombre, List<DiaYHorario> dias, List<Profesor> profesores, decimal precio)
        {
            Nombre = nombre;
            Dias = dias;
            Profesores = profesores;
            Precio = precio;
        }
    }
}
