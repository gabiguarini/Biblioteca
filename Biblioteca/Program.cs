using System;

namespace Biblioteca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Biblioteca");
            Console.WriteLine("**********");
            Console.WriteLine("");

            SocioClasico socio1 = new SocioClasico("John","Doe", 111);
            SocioVip socio2 = new SocioVip("Jane","Doe",222, 500);

            Libro libro1 = new Libro("Harry Potter", 3335, "JK");
            Ejemplar ejemplar1 = new Ejemplar(1, "pasillo 2",libro1);
            Ejemplar ejemplar2 = new Ejemplar(2, "pasillo 2", libro1);
            Console.WriteLine(libro1);

            Libro libro2 = new Libro("Call of Cthulhu", 6666, "Lovecraft");
            Ejemplar ejemplar3 = new Ejemplar(1, "Pasillo 7", libro2);
            Console.WriteLine(libro2);



        }
    }
}
