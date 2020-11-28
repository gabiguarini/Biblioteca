using System;
namespace Biblioteca
{
    public class Prestamo
    {
        public Ejemplar Ejemplar { get; set; }
        public Socio Socio { get; set; }
        public static string Fecha = DateTime.Now.ToString("MM/dd/yyyy");

        public Prestamo()
        {
        }

        public Prestamo(Socio socio, Ejemplar ejemplar)
        {
            Socio = socio;
            Ejemplar = ejemplar;
        }
    }
}
