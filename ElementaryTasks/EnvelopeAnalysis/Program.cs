using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        #region Methods

        public static void Run()
        {
            string questionMessage = "Wanna compare another envelopes?\n(say 'Y' or 'YES' to do it, or any other key to don't)";
            bool doesCompleteCicle = false;

            try
            {
                do
                {
                    (double firstWidth, double firstHeight, double secondWidth, double secondHeight)  = ReadFromConsole();
                    Envelope firstEnvelope = new Envelope(firstWidth, firstHeight);
                    Envelope secondEnvelope = new Envelope(secondWidth, secondHeight);

                    CompareEnvelops(firstEnvelope, secondEnvelope);

                    Console.WriteLine(questionMessage);
                    string userAnswer = Console.ReadLine().ToUpper().Trim();
                    if (userAnswer == "Y" || userAnswer == "YES")
                    {
                        doesCompleteCicle = true;
                        Console.Clear();
                    }
                    else
                        doesCompleteCicle = false;
                } while (doesCompleteCicle);
            }
            catch (ArgumentException e)
            {
                UserInterface.ShowErrorMessage(e);
            }
            catch (FormatException e)
            {
                UserInterface.ShowErrorMessage(e);
            }
        }

        public static (double firstWidth, double firstHeight, double secondWidth, double secondHeight) ReadFromConsole()
        {
            Console.WriteLine();                           
        }

        public static void CompareEnvelops(Envelope firstEnvelope, Envelope secondEnvelope)
        {
            bool doesFirstInSecond = firstEnvelope.DoesPutIn(secondEnvelope);
            bool doesSecondInFirst = secondEnvelope.DoesPutIn(firstEnvelope);//TODO: beauty switch

            if (doesFirstInSecond)
                UserInterface.Display("Second envelope can be put in the first envelope.");

            if (doesSecondInFirst)
                UserInterface.Display("First envelope can be put in the second envelope.");

            if (!doesFirstInSecond && !doesSecondInFirst)
                UserInterface.Display("None of the envelopes can be placed in another.");
        }

        #endregion
    }
}
