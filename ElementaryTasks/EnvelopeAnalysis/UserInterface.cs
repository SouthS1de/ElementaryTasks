using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    public static class UserInterface
    {
        #region Method

        public static (double, double, double, double) Input()
        {
            string[] inputMessages = { "Input width of the first envelope:",
                                       "Input height of the first envelope:",
                                       "Input width of the second envelope:",
                                       "Input height of the secondenvelope:"};
            string successMessage = "All sides was validated!";
            bool isSuccess = false;
            const int COUNT_OF_SIDES = 4;
            double[] result = new double[COUNT_OF_SIDES];

            for (int i = 0; i < COUNT_OF_SIDES; i++)
            {
                do
                {
                    Console.WriteLine(inputMessages[i]);
                    result[i] = Validator.Validate(Console.ReadLine());
                } while (isSuccess);
            }


            Console.WriteLine(successMessage);
        }


        public static void Display(string resultOfCompare)
        {
            Console.WriteLine("Your result of compare:");
            Console.WriteLine(resultOfCompare);
        }

        public static void ShowErrorMessage(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }

        #endregion
    }
}
