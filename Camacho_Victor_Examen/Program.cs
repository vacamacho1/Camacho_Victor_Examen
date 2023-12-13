// See https://aka.ms/new-console-template for more information

//Ejercicio 1
using Camacho_Victor_Examen;

int variable1 = 4;
int variable2 = 5;
int resultado  ;
resultado=variable1 + variable2;
 Console.WriteLine("El resultado es: "+resultado+"\n\n\n--------------------------------------");

//Ejercicio 2

int edad = 21;
if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("No es mayor de edad");
}

Console.WriteLine( "\n\n\n--------------------------------------");
//Ejercicio 3
Estudiante estudiante1 = new Estudiante("Victor", 20, 18.5f);
Console.WriteLine(estudiante1.nombre+"\n"+estudiante1.edad+"\n"+estudiante1.calificacion);
Console.WriteLine("\n\n\n--------------------------------------");
//Ejercicio 4
estudiante1.Imprimir_info();
Console.WriteLine("\n\n\n--------------------------------------");
//Ejercicio 5
EstudianteGraduado graduado1 = new EstudianteGraduado("Soraya", 45, 19.4f, "Ing.Electrica");
graduado1.Imprimir_info();
Console.WriteLine("\n\n\n--------------------------------------");