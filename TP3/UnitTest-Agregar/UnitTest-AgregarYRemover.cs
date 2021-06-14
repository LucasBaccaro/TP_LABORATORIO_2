using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTest_AgregarYRemover
{
    [TestClass]
    public class AgregarYRemover

    {
        [TestMethod]
        public void TestAgregar()
        {

            //ARRANGE
            Pantalones pantalon = new Pantalones("rojo", "aaa", EtipoMaterial.Algodon, 1.55, 1.00);
            Remeras remera = new Remeras("plateado", "sss", EtipoMaterial.Terciopelo, "M");
            Deposito<Articulo> deposito = new Deposito<Articulo>(4);
            bool resultado1;
            bool resultado2;
            //ACT
            resultado1= deposito.Agregar(pantalon);
            resultado2=deposito.Agregar(remera);
            //ASSERT
            Assert.IsTrue(resultado1 && resultado2);
            
        }

        [TestMethod]
        public void TestRemover()
        {

            //ARRANGE
            Pantalones pantalon = new Pantalones("rojo", "aaa", EtipoMaterial.Algodon, 1.55, 1.00);
            Remeras remera = new Remeras("plateado", "sss", EtipoMaterial.Terciopelo, "M");
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
