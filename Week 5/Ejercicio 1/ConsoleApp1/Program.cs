using System;
using System.Collections.Generic;

namespace DeberSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el objeto para llamar al ejercicio 1
            EjercicioUno ej = new EjercicioUno();
            ej.MostrarLista();

            // Esto evita que se cierre la consola inmediatamente
            Console.WriteLine("\nFin del programa...");
            Console.ReadKey();
        }
    }

    // Clase del Ejercicio 1
    class EjercicioUno
    {
        public void MostrarLista()
        {
            // Crear la lista de asignaturas
            List<string> asignaturas = new List<string>();

            // Agregar cada materia una por una
            asignaturas.Add("Matemáticas");
            asignaturas.Add("Física");
            asignaturas.Add("Química");
            asignaturas.Add("Historia");
            asignaturas.Add("Lengua");

            Console.WriteLine("--- ASIGNATURAS DEL CURSO ---");

            // Recorrer la lista para imprimir cada una
            foreach (string materia in asignaturas)
            {
                Console.WriteLine(materia);
            }
        }
    }
}