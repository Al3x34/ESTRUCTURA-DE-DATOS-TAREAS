using System;

namespace AgendaTelefonica
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} | Tel: {Telefono} | Email: {Email}";
        }
    }
}