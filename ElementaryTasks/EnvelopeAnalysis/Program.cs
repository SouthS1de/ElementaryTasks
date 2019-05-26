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
            double firstWidth = 0;
            double firstHeight = 0;
            double secondWidth = 0;
            double secondHeight = 0;
            string questionMessage = "Wanna compare another envelopes?\n(say 'Y' or 'YES' to do it, or any other key to don't)";
            bool doesCompleteCicle = false;

            try
            {
                do
                {
                    ReadFromConsole(ref firstWidth, ref firstHeight, ref secondWidth, ref secondHeight);
                    Envelope firstEnvelope = new Envelope(firstWidth, firstHeight);
                    Envelope secondEnvelope = new Envelope(secondWidth, secondHeight);

                    UI.Display(firstEnvelope, secondEnvelope);

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
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        #region Method

        public static void ReadFromConsole(ref double firstWidth, ref double firstHeight, ref double secondWidth, ref double secondHeight)
        {
            Console.WriteLine("Input width of the first envelope:");
            
            if (Validator.IsValidSide(Console.ReadLine(), out firstWidth))
            {
                Console.WriteLine("Input height of the first envelope:");
                if (Validator.IsValidSide(Console.ReadLine(), out firstHeight))
                {
                    Console.WriteLine("Input width of the second envelope:");
                    if (Validator.IsValidSide(Console.ReadLine(), out secondWidth))
                    {
                        Console.WriteLine("Input height of the secondenvelope:");
                        if (Validator.IsValidSide(Console.ReadLine(), out secondHeight))
                            Console.WriteLine("All sides was validated!");
                    }
                }
            }           
        }

        #endregion
    }
}
