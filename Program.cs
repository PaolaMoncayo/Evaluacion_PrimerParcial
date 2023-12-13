using Alison_Moncayo_Examen;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        // Declarar y asignar valores a las variables
        int num1 = 10;
        int num2 = 20;

        int resultado = num1 + num2;

        Console.WriteLine("Ejercicio 1" );
        Console.WriteLine("Valor de numero1: " + num1);
        Console.WriteLine("Valor de numero2: " + num2);
        Console.WriteLine("El resultado de la suma es: " + resultado);


        // Ejercicio 2
        // Declarar y asignar un valor a la variable edad
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 2");

        int edad = 20;

        // Utilizar una estructura if para determinar si es mayor de edad
        if (edad >= 18)
        {
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {

            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("La persona es menor de edad.");
        }

        // Ejercicio 3
        // Crear objeto de tipo Estudiante e inicializar propiedades
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Paola";
        estudiante1.Edad = 21;
        estudiante1.Calificacion = 9.5f;

        // Imprimir en consola 
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 3");
        Console.WriteLine("Imprimir en consola ");
        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad}");
        Console.WriteLine($"Calificación: {estudiante1.Calificacion}");



        //Ejercicio 4
        // Llamar al método MostrarInformacion del estudiante1
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Llamar al método MostrarInformacion del estudiante1");
        alumno1.MostrarInformacion();

        //Ejercicio 5
        // Crear objeto de tipo EstudianteGraduado e inicializar propiedades
        EstudianteGraduado graduado1 = new EstudianteGraduado();
        graduado1.Nombre = "Andrea";
        graduado1.Edad = 19;
        graduado1.Calificacion = 8.5f;
        graduado1.Titulo = "Ingeniero en Sistemas";

        // Utilizar el método MostrarInformacion para mostrar los detalles del estudiante graduado
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 5");
        Console.WriteLine("Utilizar el método MostrarInformacion para mostrar los detalles del estudiante graduado");
        graduado1.MostrarInformacion();
        Console.WriteLine($"Título obtenido: {graduado1.Titulo}");


    }
}
