using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {

        public Libro(string titulo, string autor, int anioPublicacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            GenerarIsbn();
            Prestado = false;
        }

        private string titulo;
        private string autor;
        private int anioPublicacion;
        private string isbn;
        private bool prestado;
       
        public string Titulo
        {
            get { return titulo; }
        }


        public string Autor
        { 
            get { return autor; }
        }

        public int AnioPublicacion
        { 
            get {  return anioPublicacion; }
        }

        public string Isbn
        {
            get { return isbn; }
        }

        public bool Prestado
        {
            get { return prestado; }

            set { prestado = value; }
        }

        private void GenerarIsbn()
        {
            string digitosCentrales = GenerarDigitosCentrales();
            int digitoControl = CalcularDigitoControl(digitosCentrales);
            isbn = "978" + digitosCentrales + digitoControl.ToString();
        }

        private string GenerarDigitosCentrales()
        {
            Random random = new Random();
            string digitos = "";
            for (int i = 0; i < 9; i++)
            {
                int digito = random.Next(10);
                digitos += digito.ToString();
            }
            return digitos;
        }

        private int CalcularDigitoControl(string digitosCentrales)
        {
            int suma = 0;
            for (int i = 0; i < digitosCentrales.Length; i++)
            {
                int digito = int.Parse(digitosCentrales[i].ToString());
                suma += (i % 2 == 0) ? digito : digito * 3; 
            }
            return (10 - (suma % 10)) % 10;

        }    

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año de Publicación: {AnioPublicacion}");
            Console.WriteLine($"ISBN: {Isbn}");
            
            string estadoLibro = prestado ? "prestado" : "disponible";
            Console.WriteLine($"Estado: {estadoLibro}");
        }
    }
}
