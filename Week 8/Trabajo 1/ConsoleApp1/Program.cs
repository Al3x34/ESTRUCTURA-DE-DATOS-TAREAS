using System;
using System.Collections.Generic; // Esto es necesario para usar "Queue" (Cola)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParque
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creamos la COLA (Queue) para la fila
            // Usamos Queue porque el primero que llega es el primero que sube
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("=== BIENVENIDOS A LA ATRACCION ===");
            Console.WriteLine("Llenando los 30 asientos...");
            Console.WriteLine("");

            // 2. Simulamos que llegan las 30 personas
            // Usamos un ciclo 'for' que va del 1 al 30
            for (int i = 1; i <= 30; i++)
            {
                string nombre = "Persona " + i;
                fila.Enqueue(nombre); // Agregamos a la persona a la cola
                Console.WriteLine(nombre + " ha llegado a la fila.");
            }

            Console.WriteLine("");
            Console.WriteLine("La fila esta llena (30 personas).");
            Console.WriteLine("Presiona ENTER para arrancar el juego...");
            Console.ReadLine(); // Pausa para que leas

            Console.WriteLine("=== SUBIENDO AL JUEGO (En orden de llegada) ===");

            // 3. Ahora suben al juego (Sacamos de la cola)
            // Mientras haya gente en la fila (Count > 0), seguimos sacando
            while (fila.Count > 0)
            {
                // Dequeue saca al primero que estaba esperando
                string personaQueSube = fila.Dequeue(); 
                Console.WriteLine("Atendiendo a: " + personaQueSube);
            }

            Console.WriteLine("");
            Console.WriteLine("Todos han subido. Fin del programa.");
            Console.ReadKey(); // Para que no se cierre la ventana
        }
    }
}