using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToStringConvertor
{
    class Program
    {
        static void Main(string[] args)
        {           
            Run(args);          
        }

        public static void Run(string[] args)
        {
            try
            {
                UserInterface.Display(Validator.Validate(args));
            }
            catch (FormatException e)
            {
                UserInterface.ShowErrorMessage(e);
            }
            catch (ArgumentNullException e)
            {
                UserInterface.ShowErrorMessage(e);
            }
            catch (ArgumentException e)
            {
                UserInterface.ShowErrorMessage(e);
            }
        }
    }
}
