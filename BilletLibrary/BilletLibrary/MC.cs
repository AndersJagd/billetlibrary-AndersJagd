using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        /// <summary>
        /// Denne klasse karaktiserer MC objekter, som arver properties og metoder fra den abstracte klasse "Køretøj"
        /// </summary>

        #region InstaceFields

        private string _nummerplade;

        #endregion

        #region Properties
        //Der er tilføjet et IF statement for at sørge for Nummerplade propertien ikke overskrider 7 tegn.
        public override string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("Nummerpladen overskrider 7 tegn!");
                }
                else
                    _nummerplade = value;
            }
        }
        public override string KøretøjType { get; set; }
        public override DateTime Dato { get; set; }
        public override decimal Pris { get; set; }
        public override bool BroBizz { get; set; }
        #endregion

        //Der er tilføjet et IF statement i constructoren, for at kaste en exception så nummerpladen ikke overskrider 7 tegn.
        #region Constructor
        public MC(string nummerplade, DateTime dato, bool broBizz)
        {
            if (nummerplade.Length > 7)
            {
                throw new Exception("Nummerpladen overskrider 7 tegn!");
            }
            else
            KøretøjType = "MC";
            Dato = dato;
            Pris = 125;
            BroBizz = broBizz;
        }
        #endregion

        #region Methods
        //Denne metode udregner prisen på bilens bro afgift. Først tjekker den om BroBizz er aktiveret, hvis den er trækker den 5% rabat af prisen,
        //hvis ikke, retunere den det fulde faste beløb.
        public override decimal pris()
        {
            if (BroBizz)
            {
                return Pris - Decimal.Multiply(Pris, new decimal(0.05));
            }
            else
            {
                return Pris;
            }
        }

        public override string køretøjType()
        {
            return KøretøjType;
        } 
        #endregion
    }
}
