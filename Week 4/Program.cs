using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda(100); 
            
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- AGENDA TELEFÓNICA (Vectores) ---");
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Mostrar Todos");
                Console.WriteLine("3. Buscar Contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Ingrese Teléfono: ");
                        string tel = Console.ReadLine();
                        Console.Write("Ingrese Email: ");
                        string mail = Console.ReadLine();
                        miAgenda.AgregarContacto(nom, tel, mail);
                        break;

                    case "2":
                        miAgenda.MostrarContactos();
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre a buscar: ");
                        string busqueda = Console.ReadLine();
                        miAgenda.BuscarContacto(busqueda);
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}