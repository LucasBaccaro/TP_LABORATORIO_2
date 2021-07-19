using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTest_Entidades
{
    [TestClass]
    public class AgregarYRemover
    {
        [TestMethod]

        //Declaro dos articulos e intento agregarlos al deposito
        public void TestAgregar()
        {
            //ARRANGE
            Pantalon pantalon = new Pantalon(Etipo.Corto, "S", "AGF233");
            Remera remera = new Remera(EColores.Negro, "M", "SFH400");
            Deposito<Articulo> deposito = new Deposito<Articulo>(4);
            bool resultado1;
            bool resultado2;
            //ACT
            resultado1 = deposito.Agregar(pantalon);
            resultado2 = deposito.Agregar(remera);
            //ASSERT
            Assert.IsTrue(resultado1 && resultado2);
        }

        [TestMethod]

        //Declaro dos articulos e intento removerlos del deposito
        public void TestRemover()
        {

            //ARRANGE
            Pantalon pantalon = new Pantalon(Etipo.Corto, "S", "AGF233");
            Remera remera = new Remera(EColores.Negro, "M", "SFH400");
            Deposito<Articulo> deposito = new Deposito<Articulo>(4);
            bool resultado1;
            bool resultado2;
            //ACT
            deposito.Agregar(remera);
            deposito.Agregar(pantalon);

            resultado1 = deposito.Remover(pantalon);
            resultado2 = deposito.Remover(remera);
            //ASSERT
            Assert.IsTrue(resultado1 && resultado2);

        }

    }
}
