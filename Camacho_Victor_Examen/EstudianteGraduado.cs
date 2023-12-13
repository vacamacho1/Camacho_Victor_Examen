using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camacho_Victor_Examen
{
    internal class EstudianteGraduado : Estudiante
    {
        private string titulo;
        public EstudianteGraduado(string nombre, int edad, float calificacion, string titulo)
            : base(nombre, edad, calificacion)
        {
            this.titulo = titulo;
        }

    }
}
