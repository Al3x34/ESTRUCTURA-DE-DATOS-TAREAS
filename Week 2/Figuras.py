using System;

// Clase Circulo
public class Circulo
{
    // Atributo privado para encapsular el radio
    private double radio;

    // Constructor para asignar el valor del radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve la circunferencia del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Cuadrado
public class Cuadrado
{
    // Atributo privado para encapsular la medida del lado
    private double lado;

    // Constructor para asignar el valor del lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // CalcularArea devuelve el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // CalcularPerimetro devuelve el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase principal para probar las figuras
public class Program
{
    public static void Main()
    {
        // Crear un círculo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Crear un cuadrado con lado 4
        Cuadrado q = new Cuadrado(4);
        Console.WriteLine("Área del cuadrado: " + q.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + q.CalcularPerimetro());
    }
}