#nullable disable
using System;

namespace Ejercicio2_Invertir
{
    // 1. Estructura básica necesaria (Nodo)
    public class Nodo {
        public int Dato;
        public Nodo Siguiente;
        public Nodo(int d) { Dato = d; Siguiente = null; }
    }

    // 2. La Lista con la función de INVERTIR
    public class ListaEnlazada {
        public Nodo Cabeza;

        // Método para agregar (necesario para crear la lista primero)
        public void Agregar(int dato) {
            Nodo nuevo = new Nodo(dato);
            if (Cabeza == null) { Cabeza = nuevo; }
            else {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null) { actual = actual.Siguiente; }
                actual.Siguiente = nuevo;
            }
        }

        // Método para ver la lista
        public void Imprimir() {
            Nodo actual = Cabeza;
            while (actual != null) {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // ---------------------------------------------------
        // EJERCICIO 2: INVERTIR LA LISTA
        // ---------------------------------------------------
        public void Invertir() {
            Nodo anterior = null;
            Nodo actual = Cabeza;
            Nodo siguiente = null;

            while (actual != null) {
                siguiente = actual.Siguiente; // Guardamos el enlace al siguiente
                actual.Siguiente = anterior;  // Invertimos la flecha hacia atrás
                anterior = actual;            // Avanzamos 'anterior'
                actual = siguiente;           // Avanzamos 'actual'
            }
            Cabeza = anterior; // El final ahora es el principio
        }
    }

    // 3. Ejecución
    class Program {
        static void Main(string[] args) {
            ListaEnlazada lista = new ListaEnlazada();
            
            // Llenamos la lista
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);
            lista.Agregar(5);

            Console.WriteLine("--- EJERCICIO 2: INVERTIR LISTA ---");
            Console.WriteLine("Lista Normal:");
            lista.Imprimir();

            // Ejecutamos la inversión
            lista.Invertir();

            Console.WriteLine("\nLista Invertida:");
            lista.Imprimir();

            Console.ReadKey();
        }
    }
}