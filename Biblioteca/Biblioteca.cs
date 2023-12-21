using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public Biblioteca()
        {
            Libros = new List<Libro>();
            Usuarios = new List<Usuario>();
            
        }
        public List<Libro> Libros { get; set;  }
        public List<Usuario> Usuarios { get; set; }  

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public Libro BuscarPorAutor(string autor)
        {
            Libro libroEncontrado = null;
            foreach (Libro libro in Libros)
            {
                if (libro.Autor == autor)
                {
                    libroEncontrado = libro;
                    break;
                }
            }
            return libroEncontrado;
        }

        public Libro BuscarPorTitulo(string titulo)
        {
            Libro libroEncontrado = null;
            foreach (Libro libro in Libros)
            {
                if(libro.Titulo == titulo)
                {
                    libroEncontrado = libro;
                    break;
                }
            }
            return libroEncontrado;
        }

        public Libro BuscarPorIsbn(string isbn)
        {
            Libro libroEncontrado = null;
            foreach(Libro libro in Libros)
            {
                if(libro.Isbn == isbn)
                {
                    libroEncontrado = libro;
                    break;
                }
            }
            return libroEncontrado;
        }

        public void PrestarLibro(Usuario usuario, string titulo)
        {
            Libro libroAPrestar = BuscarPorTitulo(titulo);
            if (libroAPrestar != null)
            {
                Console.WriteLine("Libro prestado:");
                libroAPrestar.Prestado = true;
                libroAPrestar.MostrarDetalles();

                usuario.AgregarLibrosPrestados(libroAPrestar);
            }
            else        
                Console.WriteLine("Libro no encontrado.");           
        }

        public bool ExisteUsuario(int identificador)
        {   
            bool encontrado = false;
            foreach(Usuario usuario in Usuarios) 
            {
                if (usuario.NumeroIdentificacion == identificador)
                {
                    encontrado = true;
                    break;
                }
                
            }
            return encontrado;
        }
        public void DevolverLibro(Usuario usuario, string titulo)
        {
            int idUsuario = usuario.NumeroIdentificacion;

            if (ExisteUsuario(idUsuario) && usuario.TieneLibroPrestado(titulo))
            {
                Libro libroADevolver = BuscarPorTitulo(titulo);
                if (libroADevolver != null)
                {
                    Console.WriteLine("Libro Devuelto:");
                    libroADevolver.Prestado = false;
                    libroADevolver.MostrarDetalles();
                    usuario.RemoverLibroPrestado(libroADevolver);
                }
                else
                    Console.WriteLine("el usuario no tiene el libro");              
            }
            else
     
                Console.WriteLine("No existe el usuario");
        }

    }
}
