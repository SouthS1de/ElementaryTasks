using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    public static class UI
    {
        #region Method
        
        public static void Display(Envelope firstEnvelope, Envelope secondEnvelope)
        {
            bool doesFirstInSecond = firstEnvelope.DoesPutIn(secondEnvelope);
            bool doesSecondInFirst = secondEnvelope.DoesPutIn(firstEnvelope);

            if (doesFirstInSecond)
                Console.WriteLine("Second envelope can be put in the first envelope.");

            if (doesSecondInFirst)
                Console.WriteLine("First envelope can be put in the second envelope.");

            if (!doesFirstInSecond && !doesSecondInFirst)
                Console.WriteLine("None of the envelopes can be placed in another.");
        }

        #endregion
    }
}
