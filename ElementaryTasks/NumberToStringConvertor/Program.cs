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
<<<<<<< HEAD
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
=======
                UI.Display(Validator.Validate(args));
            }
            catch (FormatException e)
            {
                UI.ShowErrorMessage(e);
            }
            catch (ArgumentNullException e)
            {
                UI.ShowErrorMessage(e);
            }
            catch (ArgumentException e)
            {
                UI.ShowErrorMessage(e);
>>>>>>> f2b24d3a2d4d2270540f089722a0890b229c7254
            }
        }
    }
}
