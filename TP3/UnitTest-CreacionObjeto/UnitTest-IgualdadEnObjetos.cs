using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTest_CreacionObjeto
{
    [TestClass]
    public class Igualdad
    {
        [TestMethod]
        public void IgualdadEnObjetosXCodigoTrue()
        {
            //ARRANGE
            Pantalones pantalon = new Pantalones("rojo", "aaa", EtipoMaterial.Algodon, 1.55, 1.00);
            Remeras remera = new Remeras("Verde", "aaa", EtipoMaterial.Terciopelo, "S");
            bool resultado;
            //ACT
            if(pantalon==remera)
            {
                resultado = true;
            }
            else { resultado = false; }
            //ASSERT
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void IgualdadEnObjetosXCodigoFalse()
        {
            //ARRANGE
            Pantalones pantalon = new Pantalones("rojo", "aaa", EtipoMaterial.Algodon, 1.55, 1.00);
            Remeras remera = new Remeras("rojo", "bbb", EtipoMaterial.Algodon, "S");
            bool resultado;
            //ACT
            if (pantalon == remera)
            {
                resultado = true;
            }
            else { resultado = false; }
            //ASSERT
            Assert.IsFalse(resultado);
        }
    }
}

