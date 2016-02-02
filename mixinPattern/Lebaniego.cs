using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Clase que implementa la interfaz ILebaniego
    /// </summary>
    public class Lebaniego : ILebaniego
    {
        /// <summary>
        /// Método hacer cocido que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo cocido</returns>
        public String hacerCocido()
        {
            return "haciendo cocido";
        }

        /// <summary>
        /// Método hacer orujo que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo orujo</returns>
        public String hacerOrujo()
        {
            return "haciendo orujo";
        }
    }
}
