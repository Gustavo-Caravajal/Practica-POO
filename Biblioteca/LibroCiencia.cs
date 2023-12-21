using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LibroCiencia : Libro
    {
        private string campoCientifico;

        public string CampoCientifico
        { 
            get { return campoCientifico; }
        }

        public LibroCiencia(string titulo, string autor, int anioPublicacion, string campoCientifico)
        : base(titulo, autor, anioPublicacion)
        {
            this.campoCientifico = campoCientifico;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Campo Cientifico: {CampoCientifico}");
        }
    }
}
