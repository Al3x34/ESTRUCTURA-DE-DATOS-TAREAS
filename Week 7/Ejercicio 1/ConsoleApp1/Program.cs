using System;
using System.Collections.Generic; // Necesario para usar Stack (Pilas)

namespace TareaEstructuraDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            // Menú simple con un ciclo
            do
            {
                Console.Clear();
                Console.WriteLine("--- TAREA DE PILAS ---");
                Console.WriteLine("1. Verificar paréntesis (Balanceo)");
                Console.WriteLine("2. Torres de Hanoi");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                
                // Leemos la opción sin mucha validación compleja
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        EjercicioBalanceo();
                        break;
                    case 2:
                        EjercicioHanoi();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }

        // --- EJERCICIO 1: BALANCEO DE PARÉNTESIS ---
        static void EjercicioBalanceo()
        {
            Console.Clear();
            Console.WriteLine("Ingresa la operación matemática:");
            string formula = Console.ReadLine();

            // Usamos una Pila de caracteres
            Stack<char> pila = new Stack<char>();
            bool error = false;

            foreach (char c in formula)
            {
                // Si abre, lo metemos a la pila
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }
                // Si cierra, verificamos
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.Count == 0) // Si está vacía, hay un error
                    {
                        error = true;
                        break;
                    }

                    char tope = pila.Pop(); // Sacamos el último

                    // Verificamos que coincidan
                    if ((c == ')' && tope != '(') ||
                        (c == ']' && tope != '[') ||
                        (c == '}' && tope != '{'))
                    {
                        error = true;
                        break;
                    }
                }
            }

            // Si no hubo error y la pila quedó vacía, está bien
            if (!error && pila.Count == 0)
            {
                Console.WriteLine("Resultado: Fórmula balanceada.");
            }
            else
            {
                Console.WriteLine("Resultado: La fórmula NO está balanceada.");
            }
        }

        // --- EJERCICIO 2: TORRES DE HANOI ---
        static void EjercicioHanoi()
        {
            Console.Clear();
            Console.Write("¿Cuántos discos quieres usar?: ");
            int discos = int.Parse(Console.ReadLine());

            // Crear las 3 pilas que representan las torres
            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            // Llenar la torre origen (el disco más grande al fondo)
            for (int i = discos; i >= 1; i--)
            {
                origen.Push(i);
            }

            Console.WriteLine($"\nIniciando con {discos} discos...");
            
            // Llamamos a la función recursiva
            MoverTorres(discos, origen, destino, auxiliar, "Torre 1", "Torre 3", "Torre 2");
        }

        // Función recursiva para mover los discos
        static void MoverTorres(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOr, string nombreDest, string nombreAux)
        {
            if (n > 0)
            {
                // Mover n-1 de Origen a Auxiliar
                MoverTorres(n - 1, origen, auxiliar, destino, nombreOr, nombreAux, nombreDest);

                // Mover el disco actual (n) de Origen a Destino
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Moviendo disco {disco} de {nombreOr} a {nombreDest}");

                // Mover n-1 de Auxiliar a Destino
                MoverTorres(n - 1, auxiliar, destino, origen, nombreAux, nombreDest, nombreOr);
            }
        }
    }
}