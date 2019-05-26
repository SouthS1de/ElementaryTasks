using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoAlgorithm();
            }
            catch(ArgumentException e)
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

        public static void DoAlgorithm()
        {
            string questionMessage = "Wanna draw another board?\n(say 'Y' or 'YES' to do it, or any other key to don't)";
            string inputMessage = "Please input the arguments of the board: ";
            string helpMessage = "FORMAT: <rows> <colomns>";
            bool doesCompleteCicle = false;
            int myRows = 0;
            int myColomns = 0;

            do
            {
                Console.WriteLine($"{inputMessage}\n{helpMessage}");
                string[] myArgs = Console.ReadLine().Split(' ');
                if (Validator.IsValidArgs(myArgs, ref myRows, ref myColomns))
                {
                    Board myBoard = new Board(myRows, myColomns);
                    ConsoleUI.BuildUI(myBoard);
                }

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

        #endregion
    }
}
