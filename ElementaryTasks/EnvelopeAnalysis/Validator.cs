using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    public static class Validator
    {
        #region Method
        
        public static bool IsValidSide(string side, out double validatedSide)//Correct bool
        {//TODO: OR bool OR Exception
            bool result = false;

            if (double.TryParse(side, out validatedSide))//TODO: TryParse to UI Metod InputDoubleSide
                result = true;
            else
                throw new FormatException("Unsuccessful format of the side inputting!");

            if (validatedSide > 0)
                result = true;
            else
                throw new ArgumentException("The side must be bigger than 0!");

            return result;
        }

        #endregion
    }
}
