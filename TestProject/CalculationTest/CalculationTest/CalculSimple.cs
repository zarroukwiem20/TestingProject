using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
   public class CalculSimple
    {
        #region Attributes
        private int _resultat ;
        #endregion 

        #region properties
        public int Resultat
        {
            get
            { return _resultat; }
            set
            { _resultat = value; }

        }
        #endregion

        #region Methods
        public int Addition (int x , int y)
        {
            return _resultat = x + y;
        }
        #endregion

        #region Constructor
        #endregion
    }
}
