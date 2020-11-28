using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Libro
    {
        public string Nombre { get; set; }
        public int IsbnId { get; set; }
        public string Autor { get; set; }

        public List<Ejemplar> ejemplares = new List<Ejemplar>();

        public Libro()
        {

        }

        public Libro(string nombre, int isbnid, string autor)
        {
            Nombre = nombre;
            IsbnId = isbnid;
            Autor = autor;
        }

        public void addEjemplar(Ejemplar ejemplar)
        {

           ejemplares.Add(ejemplar);
    
        }

        public bool hayEjemplar()
        {
            Console.WriteLine("Revisando la biblioteca...");
            if (!ejemplares?.Any() ?? false)
            {
                Console.WriteLine("No hay ejemplares disponibles.");
                return false;
            }
            else
            {
                Console.WriteLine("Hay ejemplares disponibles.");
                return true;
            }
        }

        public void prestarEjemplar()
        {
            var firstItem = ejemplares.ElementAt(0);
            Console.WriteLine("Prestando el ejemplar:");
            Console.Write(firstItem);

            ejemplares.RemoveAt(0);
        }

        public override string ToString()
        {
            return string.Format("Titulo: {0}, Autor: {1}, ISBN: {2}", Nombre, Autor, IsbnId);
        }

    }
}
