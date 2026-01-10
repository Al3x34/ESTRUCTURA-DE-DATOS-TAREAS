using System;
using System.Collections.Generic;

namespace DeberSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioCuatro loteria = new EjercicioCuatro();
            loteria.OrdenarNumeros();

            Console.WriteLine("\nFin del programa...");
            Console.ReadKey();
        }
    }

    class EjercicioCuatro
    {
        public void OrdenarNumeros()
        {
            // Lista de enteros para guardar los números
            List<int> boletos = new List<int>();

            Console.WriteLine("--- LOTERÍA PRIMITIVA ---");

            // Pedimos los 6 números uno por uno
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("Introduce el número ganador " + i + ": ");
                // Leemos y convertimos a entero
                int n = int.Parse(Console.ReadLine());
                boletos.Add(n);
            }

            // Esta función ordena la lista automáticamente de menor a mayor
            boletos.Sort();

            Console.WriteLine("\nNúmeros ganadores ordenados:");

            // Imprimimos la lista ordenada
            foreach (int num in boletos)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Salto de línea final
        }
    }
}