using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LibroFiccion : Libro
    {

        private string genero;
        public string Genero 
        {
            get { return genero; }
        }

        public LibroFiccion(string titulo, string autor, int anioPublicacion, string genero)
        : base(titulo, autor, anioPublicacion)
        {
            this.genero = genero;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Genero: {Genero}");
        }
    }
}
