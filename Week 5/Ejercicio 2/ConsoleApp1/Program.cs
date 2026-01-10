using System;
using System.Collections.Generic;

namespace DeberSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamamos a la clase del ejercicio 2
            EjercicioDos tarea = new EjercicioDos();
            tarea.MostrarMensajes();

            Console.WriteLine("\nFin del programa...");
            Console.ReadKey();
        }
    }

    // Clase para el Ejercicio 2
    class EjercicioDos
    {
        public void MostrarMensajes()
        {
            // Creamos la lista con las materias ya incluidas
            List<string> asignaturas = new List<string>() { 
                "Matemáticas", "Física", "Química", "Historia", "Lengua" 
            };

            Console.WriteLine("--- MENSAJES ---");

            // Recorremos y completamos la frase
            foreach (string materia in asignaturas)
            {
                Console.WriteLine("Yo estudio " + materia);
            }
        }
    }
}