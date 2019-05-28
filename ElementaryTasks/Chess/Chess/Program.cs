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
            string helpMessage = "USE FORMAT: <rows> <colomns>";
            Console.WriteLine(helpMessage);

            try
            {
                Run(args);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(helpMessage);
                Console.ReadLine();
            }
        }

        #region Method

        public static void Run(string[] myArgs)
        {
            int myRows = 0;
            int myColomns = 0;
            if (Validator.IsValidArgs(myArgs, ref myRows, ref myColomns))
            {
                Board myBoard = new Board(myRows, myColomns);
                ConsoleUI.BuildUI(myBoard);
            }            
        }

        #endregion
    }
}
