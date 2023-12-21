using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {

        public Usuario(string nombre, int numeroIdentificacion) 
        { 
            this.nombre = nombre;
            this.numeroIdentificacion = numeroIdentificacion;
            LibrosPrestados = new List<Libro>();

        }

        private string nombre;

        private int numeroIdentificacion;
        public List<Libro> LibrosPrestados { get; set; } 

        public string Nombre { get{ return nombre;} }

        public int NumeroIdentificacion { get { return numeroIdentificacion;} }

        public void AgregarLibrosPrestados(Libro libro) 
        {
            LibrosPrestados.Add(libro);
        }

        public bool TieneLibroPrestado(string titulo)
        {   bool encontrado = false;

            foreach(Libro libro in LibrosPrestados)
            {
                if (libro.Titulo == titulo)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public void RemoverLibroPrestado(Libro libro)
        {
            LibrosPrestados.Remove(libro);
        }
    }
}
