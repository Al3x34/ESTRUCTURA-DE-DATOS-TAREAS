using System;

namespace AgendaTelefonica
{
    public class Agenda
    {
        private Contacto[] listaContactos;
        private int contador;
        private int capacidadMaxima;

        public Agenda(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.listaContactos = new Contacto[capacidad];
            this.contador = 0;
        }

        public void AgregarContacto(string nombre, string telefono, string email)
        {
            if (contador < capacidadMaxima)
            {
                listaContactos[contador] = new Contacto(nombre, telefono, email);
                contador++;
                Console.WriteLine(">> Contacto guardado exitosamente.");
            }
            else
            {
                Console.WriteLine(">> Error: La agenda está llena.");
            }
        }

        public void MostrarContactos()
        {
            Console.WriteLine("\n--- LISTA DE CONTACTOS ---");
            if (contador == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaContactos[i].ToString()}");
                }
            }
        }

        public void BuscarContacto(string nombreBusqueda)
        {
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (listaContactos[i].Nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                {
                    Console.WriteLine($"Encontrado: {listaContactos[i].ToString()}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine(">> No se encontraron coincidencias.");
            }
        }
    }
}