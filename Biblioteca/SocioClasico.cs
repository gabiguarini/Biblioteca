using System;

namespace Biblioteca
{
    public class SocioClasico : Socio
    {

        public override int CantMax { get { return 3; } }

        public SocioClasico()
        {

        }

        public SocioClasico(string nombre, string apellido, int socioid): base(nombre, apellido, socioid)
        {

        }

    }
}
