using System;
using System.Collections.Generic;

namespace DeberSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioCinco tarea = new EjercicioCinco();
            tarea.InvertirNumeros();

            Console.WriteLine("\nFin del programa...");
            Console.ReadKey();
        }
    }

    class EjercicioCinco
    {
        public void InvertirNumeros()
        {
            // Lista de números
            List<int> numeros = new List<int>();

            // 1. Llenamos la lista con números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            Console.WriteLine("--- NÚMEROS INVERSOS ---");

            // 2. Recorremos la lista HACIA ATRÁS
            // Empezamos en el final (Count - 1) y vamos bajando hasta 0
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                Console.Write(numeros[i]);

                // Si 'i' es mayor a 0, significa que aún quedan números,
                // así que ponemos una coma.
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); // Salto de línea final
        }
    }
}