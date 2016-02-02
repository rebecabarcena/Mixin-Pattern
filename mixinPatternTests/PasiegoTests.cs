using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Tests
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Clase para probar la clase Pasiego
    /// </summary>
    [TestClass()]
    public class PasiegoTests
    {
        /// <summary>
        /// Test para el método hacerSobaos. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerSobaosTest()
        {
            Pasiego pasiego = new Pasiego();
            String actual = pasiego.hacerSobaos();
            String expected = "haciendo sobaos";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerQuesada. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerQuesadaTest()
        {
            Pasiego pasiego = new Pasiego();
            String actual = pasiego.hacerQuesada();
            String expected = "haciendo quesada";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerCocido. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerCocidoTest()
        {
            Pasiego pasiego = new Pasiego();
            String actual = pasiego.hacerCocido();
            String expected = "haciendo cocido";
            Assert.AreEqual(actual, expected);
        }
    }
}