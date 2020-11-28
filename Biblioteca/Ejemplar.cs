using System;
namespace Biblioteca
{
    public class Ejemplar
    {
        public int NroEdicion { get; set; }
        public string Ubicacion { get; set; }

        public Libro Libro { get; set; }

        public Ejemplar()
        {
        }

        public Ejemplar(int nroedicion, string ubicacion, Libro libro)
        {
            NroEdicion = nroedicion;
            Ubicacion = ubicacion;
            Libro = libro;
        }

        
    }
}
