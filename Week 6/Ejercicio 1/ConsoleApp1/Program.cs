using System;

namespace TareaEstructuraDatos
{
    // Clase Nodo (Obligatoria)
    public class Nodo {
        public int Dato;
        public Nodo Siguiente;
        public Nodo(int d) { Dato = d; Siguiente = null; }
    }

    public class ListaEnlazada {
        public Nodo Cabeza;

        // Método para agregar rápido (necesario para probar)
        public void Agregar(int dato) {
            Nodo nuevo = new Nodo(dato);
            if (Cabeza == null) { Cabeza = nuevo; }
            else {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null) { actual = actual.Siguiente; }
                actual.Siguiente = nuevo;
            }
        }

        // --- EJERCICIO 1: Contar Elementos ---
        public int Contar() {
            int total = 0;
            Nodo actual = Cabeza;
            while (actual != null) {
                total++;
                actual = actual.Siguiente;
            }
            return total;
        }
    }

    class Program {
        static void Main(string[] args) {
            ListaEnlazada lista = new ListaEnlazada();
            
            // Agregamos 3 números
            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);

            // Probamos el Ejercicio 1
            Console.WriteLine("Total elementos: " + lista.Contar());
            Console.ReadKey();
        }
    }
}