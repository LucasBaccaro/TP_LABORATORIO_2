using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTest_Entidades
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        //Pruebo serializar el listado de productos fabricados
        public void ProbarExcepcionNoHayLugar()
        {
            try
            {
                Deposito<Articulo> depo = new Deposito<Articulo>(1);

                Pantalon P1 = new Pantalon(Etipo.Corto, "S", "ADG23");
                Pantalon P2 = new Pantalon(Etipo.Corto, "M", "3DS23");

                depo.Agregar(P1);
                depo.Agregar(P2);

                Assert.Fail();

            }catch(NoHayLugarException e)
            {
                Assert.IsInstanceOfType(e, typeof(NoHayLugarException));
            }
            
        }

    }
}
