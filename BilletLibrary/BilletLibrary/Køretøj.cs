using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BilletLibrary
{

    /// <summary>
    /// Denne abstract klasse bliver brugt som en skabelon til diverse køretøjs klasser.
    /// Den vil kræve nummerplade, dato, pris, brobizz på hver klasse der arver fra denne.
    /// </summary>

    public abstract class Køretøj
    {
        #region Properties
        //Tilføjet en Exception, som bliver kastet hvis nummerplade propertien overstiger 7 tegn.
        public abstract string Nummerplade { get; set; }

        public abstract string KøretøjType { get; set; }

        public abstract DateTime Dato { get; set; }

        public abstract decimal Pris { get; set; }

        public abstract bool BroBizz { get; set; }
        #endregion

        #region Methods
        //Denne metode retunere propertien "Pris".
        public abstract decimal pris();

        //Denne metode retunere propertien "KøreTøjType".
        public abstract string køretøjType();

        #endregion
    }
}
