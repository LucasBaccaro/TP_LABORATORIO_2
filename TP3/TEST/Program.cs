using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pantalones pantalon1 = new Pantalones("rojo", "aaa", EtipoMaterial.Algodon, 1.55, 1.00);
                Pantalones pantalon2 = new Pantalones("azul", "bb", EtipoMaterial.Terciopelo, 1.33, 1.34);
                Pantalones pantalon3 = new Pantalones("verde", "ccc", EtipoMaterial.Algodon, 1.33, 2.00);

                Remeras remera1 = new Remeras("plateado", "sss", EtipoMaterial.Terciopelo,"S");
                Remeras remera2 = new Remeras("azul", "hgfh", EtipoMaterial.Algodon, "L");
                Remeras remera3 = new Remeras("amarillo", "fgfd", EtipoMaterial.Terciopelo, "S");
                Remeras remera4 = new Remeras("morado", "sss", EtipoMaterial.Terciopelo, "XL");

                Deposito<Articulo> deposito = new Deposito<Articulo>(4);


                if (pantalon1 != pantalon2)
                {
                    deposito.Agregar(pantalon1);
                    deposito.Agregar(pantalon2);
                }

                if (remera1 == remera4)
                {
                    Console.WriteLine("Misco codigo, no se puede agregar");
                }

                deposito.Agregar(remera2);

                deposito.Remover(pantalon2);

                Console.WriteLine(deposito);

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
