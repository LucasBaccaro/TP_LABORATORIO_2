using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Pantalon pantalon1 = new Pantalon(Etipo.Corto, "M", "pantalon1");
            Pantalon pantalon2 = new Pantalon(Etipo.Largo, "S", "pantalon2");
            Pantalon pantalon3 = new Pantalon(Etipo.Corto, "XL", "pantalon3");

            Remera remera1 = new Remera(EColores.Azul,"S","remera1");
            Remera remera2 = new Remera(EColores.Negro,"S","remera2");
            Remera remera3 = new Remera(EColores.Verde,"M","remera3");

            Deposito<Articulo> depo = new Deposito<Articulo>(6);

            depo.Agregar(pantalon1);
            depo.Agregar(pantalon2);
            depo.Agregar(pantalon3);


            depo.Agregar(remera1);
            depo.Agregar(remera2);
            depo.Agregar(remera3);

            Console.WriteLine(depo);

            Console.ReadKey();

        }
    }
}
