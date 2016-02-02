using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Interfaz con los métodos propios de un liebaniego
    /// </summary>
    interface ILebaniego
    {
        /// <summary>
        /// Método hacer cocido
        /// </summary>
        String hacerCocido();

        /// <summary>
        /// Método hacer orujo
        /// </summary>
        /// <returns></returns>
        String hacerOrujo();
    }
}
