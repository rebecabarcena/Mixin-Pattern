using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Clase que implementa la interfaz IPasiego
    /// </summary>
    public class Pasiego : IPasiego
    {
        /// <summary>
        /// Método hacer sobaos que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo sobaos</returns>
        public String hacerSobaos()
        {
            return "haciendo sobaos";
        }

        /// <summary>
        /// Método hacer quesada que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo quesada</returns>
        public String hacerQuesada()
        {
            return "haciendo quesada";
        }

        /// <summary>
        /// Método hacer cocido que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo cocido</returns>
        public String hacerCocido()
        {
            return "haciendo cocido";
        }
    }
}
