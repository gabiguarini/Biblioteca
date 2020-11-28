using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Socio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int SocioId { get; set; }
        public abstract int CantMax { get; }

        public List<Ejemplar> retirados = new List<Ejemplar>();

        public Socio()
        {

        }

        public Socio(string nombre, string apellido, int socioid)
        {
            Nombre = nombre;
            Apellido = apellido;
            SocioId = socioid;
        }

        public void addRetirado(Ejemplar retirado)
        {
            for (int x = 0; x <= CantMax; x++)
            {
                retirados.Add(retirado);
            }
        }

        public bool tieneCupo()
        {
            Console.WriteLine("Estamos revisando si tiene cupo disponible :)");
            if (retirados.Count == CantMax)
            {
                Console.WriteLine("No tiene cupo disponible.");
                return false;
            }
            else
            {
                int cupo = CantMax - retirados.Count;
                Console.WriteLine("Tiene cupo de {0} disponible.", cupo);
                return true;
            }
        }

        public void devolverEjemplar(Ejemplar devuelto)
        {
            retirados.Remove(devuelto);
        }
    }
}
