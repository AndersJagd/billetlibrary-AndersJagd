using System;
using BilletLibrary;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTester
{
    [TestClass]
    public class MCtests
    {
        /// <summary>
        /// Denne test ser om pris metoden kan genkende om BroBizz er aktiv eller ej. Her er BroBizz aktiveret,
        /// s� prisen burde ikke v�re equal til 125, men 118.75.
        /// </summary>
        [TestMethod]
        public void MCBroBizzPrisTest()
        {
            //Arrange
            var MCOne = new MC("AB11121", DateTime.Today, true);

            //Act
            MCOne.Pris = MCOne.pris();

            //Assert
            Assert.AreNotEqual(125, MCOne.Pris);
            Assert.AreEqual(new decimal(118.75), MCOne.Pris);
           
        }

        /// <summary>
        /// Her testes pris metoden om den kan l�se hvis BroBizz er deaktiveret. Den skulle gerne returnere den fastsatte pris 125.
        /// </summary>
        [TestMethod]
        public void MCPrisTest()
        {
            //Arrange
            var MCOne = new MC("AB11121", DateTime.Today, false);

            //Act
            MCOne.Pris = MCOne.pris();

            //Assert
            Assert.AreNotEqual(new decimal(118.75), MCOne.Pris);
            Assert.AreEqual(125, MCOne.Pris);

        }

        /// <summary>
        /// Her testes k�ret�j metoden, som retunere k�ret�jstypen af objektet. I dette tilf�lde, skal det v�re "MC".
        /// </summary>
        [TestMethod]
        public void MCK�ret�jTest()
        {
            //Arrange
            var MCOne = new MC("AB11121", DateTime.Today, false);

            //Act
            MCOne.K�ret�jType = MCOne.k�ret�jType();

            //Assert
            Assert.AreEqual("MC", MCOne.K�ret�jType);

        }

        /// <summary>
        /// Tester om der bliver kastet en exception, hvis nummerpladen overskrider 7 tegn. OBS! Testen skal fejle!!
        /// </summary>
        [TestMethod]
        public void MCNummerpladeTest()
        {
            //Arrange
            var bilOne = new Bil("AB342TJ1", DateTime.Today, false);

            //Act


            //Assert
            Assert.AreEqual(8, bilOne.Nummerplade.Length);
        }

        /// <summary>
        /// Tester om der bliver kastet en exception, hvis �ndringer g�r at nummerpladen overskrider 7 tegn. OBS! Testen skal fejle!
        /// </summary>
        [TestMethod]
        public void MCSetNummerpladeTest()
        {
            //Arrange
            var MCOne = new Bil("AB342TJ", DateTime.Today, false);

            //Act
            MCOne.Nummerplade = "12345678";

            //Assert
            Assert.AreEqual(8, MCOne.Nummerplade.Length);
        }


    }
}
