using System;
namespace Biblioteca
{
    public class SocioVip : Socio
    {
        public decimal Cuota { get; set; }
        public override int CantMax { get{ return 15;  } }
        
        public SocioVip(string nombre, string apellido, int socioid, decimal cuota) : base(nombre, apellido, socioid)
        {
            Cuota = cuota;
        }

    }
}
