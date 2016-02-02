using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Interfaz con los métodos propios de un pasiego
    /// </summary>
    interface IPasiego
    {
        /// <summary>
        /// Método hacer sobaos
        /// </summary>
        /// <returns></returns>
        String hacerSobaos();
        
        /// <summary>
        /// Método hacer quesada
        /// </summary>
        /// <returns></returns>
        String hacerQuesada();

        /// <summary>
        /// Método hacer cocido
        /// </summary>
        /// <returns></returns>
        String hacerCocido();
    }
}
