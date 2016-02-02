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
    /// Clase para probar la clase PasiegoLebaniego
    /// </summary>
    [TestClass()]
    public class PasiegoLebaniegoTests
    {
        /// <summary>
        /// Tests para el método hacerCocido. Comprueba si
        /// el String a retornar es correcto en función
        /// del contexto que tenga.
        /// </summary>
        /// 
        [TestMethod()]
        public void hacerCocidoTest()
        {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            String actual = pl.hacerCocido();
            String expected = "haciendo cocido pasiego";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void hacerCocidoTest2() {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            pl.Contexto = PasiegoLebaniego.TipoContexto.LIEBANA;
            String actual = pl.hacerCocido();
            String expected = "haciendo cocido lebaniego";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void hacerCocidoTest3() {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            pl.Contexto = PasiegoLebaniego.TipoContexto.PAS;
            String actual = pl.hacerCocido();
            String expected = "haciendo cocido pasiego";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerOrujo. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerOrujoTest()
        {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            String actual = pl.hacerOrujo();
            String expected = "haciendo orujo";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerQuesada. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerQuesadaTest()
        {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            String actual = pl.hacerQuesada();
            String expected = "haciendo quesada";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test para el método hacerSobaos. Comprueba si
        /// el String a retornar es correcto
        /// </summary>
        [TestMethod()]
        public void hacerSobaosTest()
        {
            PasiegoLebaniego pl = new PasiegoLebaniego();
            String actual = pl.hacerSobaos();
            String expected = "haciendo sobaos";
            Assert.AreEqual(actual, expected);
        }
    }
}