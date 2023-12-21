using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear la biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Agregar libros a la biblioteca
            Libro libro1 = new Libro("La Sombra del Viento", "Carlos Ruiz Zafón", 2001);
            Libro libro2 = new LibroFiccion("1984", "George Orwell", 1949, "Distopía");
            Libro libro3 = new LibroCiencia("Cosmos", "Carl Sagan", 1980, "Astronomía");

            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            // Agregar usuarios a la biblioteca
            Usuario usuario1 = new Usuario("Juan Perez", 12345);
            Usuario usuario2 = new Usuario("Maria Gomez", 67890);

            biblioteca.AgregarUsuario(usuario1);
            biblioteca.AgregarUsuario(usuario2);

            // Mostrar detalles de los libros en la biblioteca
            Console.WriteLine("Detalles de los libros en la biblioteca:");
            foreach (Libro libro in biblioteca.Libros)
            {
                libro.MostrarDetalles();
                Console.WriteLine("------------------------------");
            }

            // Prestar un libro y mostrar detalles del usuario y el libro prestado
            Console.WriteLine("Prestar libro a usuario:");
            biblioteca.PrestarLibro(usuario1, "La Sombra del Viento");

            // Mostrar detalles del usuario y el libro prestado
            Console.WriteLine("Detalles del usuario y libro prestado:");
            Console.WriteLine($"Detalles del usuario {usuario1.Nombre} ({usuario1.NumeroIdentificacion}):");
            foreach (Libro libro in usuario1.LibrosPrestados)
            {
                libro.MostrarDetalles();
                Console.WriteLine("------------------------------");
            }

            // Intentar prestar un libro inexistente
            Console.WriteLine("Intentar prestar un libro inexistente:");
            biblioteca.PrestarLibro(usuario2, "Libro Inexistente");

            // Devolver un libro y mostrar detalles del usuario y el libro devuelto
            Console.WriteLine("Devolver un libro:");
            biblioteca.DevolverLibro(usuario1, "La Sombra del Viento");

            // Mostrar detalles del usuario y el libro devuelto
            Console.WriteLine("Detalles del usuario y libro devuelto:");
            Console.WriteLine($"Detalles del usuario {usuario1.Nombre} ({usuario1.NumeroIdentificacion}):");
            foreach (Libro libro in usuario1.LibrosPrestados)
            {
                libro.MostrarDetalles();
                Console.WriteLine("------------------------------");
            }

            // Intentar devolver un libro inexistente o de un usuario inexistente
            Console.WriteLine("Intentar devolver un libro inexistente o de un usuario inexistente:");
            biblioteca.DevolverLibro(usuario1, "Libro Inexistente");
            biblioteca.DevolverLibro(new Usuario("Usuario Inexistente", 99999), "La Sombra del Viento");

            Console.ReadKey();
        }
    }
}
