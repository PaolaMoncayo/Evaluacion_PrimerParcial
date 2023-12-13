using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Moncayo_Examen
{
    internal class Estudiante

    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Calificacion { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Calificación: {Calificacion}");
        }
    }



}
