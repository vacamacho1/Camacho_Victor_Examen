using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camacho_Victor_Examen
{
    internal class Estudiante
    {
         public string nombre;
        public int edad;
        public float calificacion;

        public Estudiante(string nombre, int edad, float calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificacion = calificacion;
        }
        public void Imprimir_info()
        {
            Console.WriteLine("Nombre: " + this.nombre+" Edad: "+this.edad+ " Calificacion: " + this.calificacion );
        }
    }
}
