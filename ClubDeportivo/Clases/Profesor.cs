using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClubDeportivo.Clases
{
    public class Profesor : Persona
    {
        public string Titulo { get; set; }

        public Profesor(string nombre, string apellido, string dni, string telefono,
                        string direccion, DateTime fechaInscripcion, bool fichaMedica,
                        string titulo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            Direccion = direccion;
            FechaInscripcion = fechaInscripcion;
            FichaMedica = fichaMedica;
            Activo = true;
            Titulo = titulo;
        }
        public override bool EstadoActividad()
        {
            return Activo && FichaMedica;
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Titulo}";
        }

    }
}
