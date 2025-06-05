using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    public class DiaYHorario
    {
        public DayOfWeek Dia { get; set; }            // Enum (Lunes, Martes...)
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public DiaYHorario(DayOfWeek dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            Dia = dia;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
        public override string ToString()
        {
            return $"{Dia}: {HoraInicio:hh\\:mm} a {HoraFin:hh\\:mm}";
        }
    }
}
