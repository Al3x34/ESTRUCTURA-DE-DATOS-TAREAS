using System;
using System.Collections.Generic;

namespace DeberSemana5
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioTres tarea = new EjercicioTres();
            tarea.ProcesarNotas();

            Console.WriteLine("\nFin del programa...");
            Console.ReadKey();
        }
    }

    class EjercicioTres
    {
        public void ProcesarNotas()
        {
            // Lista de materias
            List<string> materias = new List<string>() { 
                "Matemáticas", "Física", "Química", "Historia", "Lengua" 
            };

            // Lista para guardar las notas
            List<double> notas = new List<double>();

            Console.WriteLine("--- INGRESO DE NOTAS ---");

            // Parte 1: Pedir las notas al usuario
            foreach (string m in materias)
            {
                Console.Write("¿Qué nota has sacado en " + m + "?: ");
                // Leemos lo que escribe el usuario y lo convertimos a número
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);
            }

            Console.WriteLine("\n--- BOLETÍN DE CALIFICACIONES ---");

            // Parte 2: Mostrar materia con su nota
            // Usamos un 'for' para sacar el dato de las dos listas a la vez
            for (int i = 0; i < materias.Count; i++)
            {
                Console.WriteLine("En " + materias[i] + " has sacado " + notas[i]);
            }
        }
    }
}