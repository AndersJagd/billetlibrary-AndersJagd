using System;
using BilletLibrary;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTester
{
    [TestClass]
    public class Biltests
    {
        /// <summary>
        /// Denne test ser om pris metoden kan genkende om BroBizz er aktiv eller ej. Her er BroBizz aktiveret,
        /// så prisen burde ikke være equal til 240, men 228.
        /// </summary>
        [TestMethod]
        public void BilBroBizzPrisTest()
        {
            //Arrange
            var bilOne = new Bil("AB11121", DateTime.Today, true);

            //Act
            bilOne.Pris = bilOne.pris();

            //Assert
            Assert.AreNotEqual(240, bilOne.Pris);
            Assert.AreEqual(228, bilOne.Pris);
           
        }

        /// <summary>
        /// Her testes pris metoden om den kan læse hvis BroBizz er deaktiveret. Den skulle gerne returnere den fastsatte pris 240.
        /// </summary>
        [TestMethod]
        public void BilPrisTest()
        {
            //Arrange
            var bilOne = new Bil("AB11121", DateTime.Today, false);

            //Act
            bilOne.Pris = bilOne.pris();

            //Assert
            Assert.AreNotEqual(228, bilOne.Pris);
            Assert.AreEqual(240, bilOne.Pris);

        }

        /// <summary>
        /// Her testes køretøj metoden, som retunere køretøjstypen af objektet. I dette tilfælde, skal det være "Bil".
        /// </summary>
        [TestMethod]
        public void BilKøretøjTest()
        {
            //Arrange
            var bilOne = new Bil("AB11121", DateTime.Today, false);

            //Act
            bilOne.KøretøjType = bilOne.køretøjType();

            //Assert
            Assert.AreEqual("Bil", bilOne.KøretøjType);

        }

        /// <summary>
        /// Tester om der bliver kastet en exception, hvis nummerpladen overskrider 7 tegn. OBS! Testen skal fejle!!
        /// </summary>
        [TestMethod]
        public void BilNummerpladeTest()
        {
            //Arrange
            var bilOne = new Bil("AB342TJ1", DateTime.Today, false);

            //Act
           

            //Assert
            Assert.AreEqual(8, bilOne.Nummerplade.Length);
        }

        /// <summary>
        /// Tester om der bliver kastet en exception, hvis ændringer gør at nummerpladen overskrider 7 tegn. OBS! Testen skal fejle!
        /// </summary>
        [TestMethod]
        public void BilSetNummerpladeTest()
        {
            //Arrange
            var bilOne = new Bil("AB342TJ", DateTime.Today, false);

            //Act
            bilOne.Nummerplade = "12345678";

            //Assert
            Assert.AreEqual(8, bilOne.Nummerplade.Length);
        }

    }
}
