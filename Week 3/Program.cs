using System;

class Estudiante
{
    public int ID;
    public string Nombres = "";
    public string Apellidos = "";
    public string Direccion = "";
    public string[] Telefonos = new string[3];

    public void MostrarDatos()
    {
        Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($" - Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        // ID con TryParse para evitar errores
        int tempID;
        Console.Write("Ingrese el ID del estudiante: ");
        while (!int.TryParse(Console.ReadLine(), out tempID))
        {
            Console.Write("ID inválido. Ingrese un número: ");
        }
        estudiante.ID = tempID;

        Console.Write("Ingrese los nombres: ");
        estudiante.Nombres = Console.ReadLine() ?? "";

        Console.Write("Ingrese los apellidos: ");
        estudiante.Apellidos = Console.ReadLine() ?? "";

        Console.Write("Ingrese la dirección: ");
        estudiante.Direccion = Console.ReadLine() ?? "";

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Ingrese el teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine() ?? "";
        }

        // Mostrar datos
        estudiante.MostrarDatos();
    }
}
