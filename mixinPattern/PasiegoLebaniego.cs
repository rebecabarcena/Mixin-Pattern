using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    /// <author>Rebeca Barcena Orero</author>
    /// <summary>
    /// Clase que implementa ls interfaces IPasiego
    /// e ILebaniego
    /// </summary>
    public class PasiegoLebaniego : IPasiego, ILebaniego
    {
        /// <summary>
        /// Clase enumerada que define los tipos de contexto
        /// posibles para un PasiegoLebaniego
        /// </summary>
        public enum TipoContexto {LIEBANA, PAS};

        // Atributo que indica el contexto del PasiegoLebaniego
        // Por defecto, le ponemos que está en la región del PAS
        private TipoContexto _contexto = TipoContexto.PAS;

        // Definición de la propiedad correspondiente a _contexto
        public TipoContexto Contexto
        {
            get
            {
                return _contexto;
            }

            set
            {
                _contexto = value;
            }
        }

        /// <summary>
        /// Atributo del tipo del Padre Lebaniego
        /// </summary>
        private ILebaniego mixinLebaniego = new Lebaniego();

        /// <summary>
        /// Definición de la propiedad
        /// </summary>
        internal ILebaniego MixinLebaniego
        {
            get
            {
                return mixinLebaniego;
            }

            set
            {
                mixinLebaniego = value;
            }
        }

        /// <summary>
        /// Atributo del tipo del Padre Pasiego
        /// </summary>
        private IPasiego mixinPasiego = new Pasiego();

        /// <summary>
        /// Definición de la propiedad
        /// </summary>
        internal IPasiego MixinPasiego
        {
            get
            {
                return mixinPasiego;
            }

            set
            {
                mixinPasiego = value;
            }
        }

        /// <summary>
        /// Método hacer cocido que retorna un String
        /// indicando la opción que se está realizando
        /// dependiendo del contexto
        /// </summary>
        /// <returns>haciendo cocido lebaniego si el
        ///          contexto es LIEBANA
        ///          haciendo cocido pasiego si el
        ///          contexto es PAS
        ///          no se hacer cocido si el contexto
        ///          es null</returns>
        public string hacerCocido()
        {
            switch (Contexto)
            {
                case TipoContexto.LIEBANA:
                    return MixinLebaniego.hacerCocido() + " lebaniego";
                case TipoContexto.PAS:
                    return MixinPasiego.hacerCocido() + " pasiego";
                // en principio no debería alcanzar nunca este default,
                // porque no le podemos pasar más tipos que los definidos
                // en TipoContexto y, por ahora, sólo hay dos
                default:
                    return "no se hacer cocido";
            }
        }

        /// <summary>
        /// Método hacer orujo que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo orujo</returns>
        public string hacerOrujo()
        {
            return MixinLebaniego.hacerOrujo();
        }
        
        /// <summary>
        /// Método hacer quesada que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo quesada</returns>
        public string hacerQuesada()
        {
            return MixinPasiego.hacerQuesada();
        }

        /// <summary>
        /// Método hacer sobaos que retorna un String
        /// indicando la acción que se realiza.
        /// </summary>
        /// <returns>haciendo sobaos</returns>
        public string hacerSobaos()
        {
            return MixinPasiego.hacerSobaos();
        }
    }
}
