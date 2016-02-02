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
    /// Clase para probar la clase Lebaniego
    /// </summary>
    [TestClass()]
    public class LebaniegoTests
    {
        /// <summary>
        /// Test para el método hacerCocido. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerCocidoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            String actual = lebaniego.hacerCocido();
            String expected = "haciendo cocido";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerOrujo. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerOrujoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            String actual = lebaniego.hacerOrujo();
            String expected = "haciendo orujo";
            Assert.AreEqual(actual, expected);
        }
    }
}