using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotNullList()
        {
            //Arrange
            Fabrica fabrica;

            //Act
            fabrica = new Fabrica();


            //Assert
            Assert.IsNotNull(fabrica.Buzos);
            


        }

        [TestMethod]
        [ExpectedException(typeof(SinEspacioException))]
        public void Exception()
        {
            //Arrange
            Fabrica fabrica = new Fabrica(20);
            Buzos corte = new Buzos(2, 6, 4, 2, 1, 10, false, enumMarca.Nike, "Just Do It");//23


            //Act
            fabrica += corte;





        }
        [TestMethod]
        public void Add()
        {
            //Arrange
            Fabrica fabrica = new Fabrica();

            //Act
            Buzos corte = new Buzos(2, 6, 4, 2, 1, 10, false, enumMarca.Nike, "Just Do It");//
            fabrica += corte;

            //Assert
            Assert.AreEqual(fabrica.Buzos[0],corte);



        }

    }
}
