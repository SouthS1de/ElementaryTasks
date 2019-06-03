using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    public static class Validator
    {
        private const int INVALID_VALUE = -1;

        #region Method
        
        public static (bool, double) Validate(string side)//Correct bool
        {
            if (double.TryParse(side, out double validatedSide))
            {
                if (validatedSide < 0)
                {
                    Console.WriteLine("The side must be bigger than 0!");
                    return (false, INVALID_VALUE);
                }                
                else
                    return (true, validatedSide);
            }
            else
                return (false, INVALID_VALUE);            
        }

        #endregion
    }
}
