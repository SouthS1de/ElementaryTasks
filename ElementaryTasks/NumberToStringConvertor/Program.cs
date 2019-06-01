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
            Console.WriteLine(args[0]);
            int number = int.Parse(args[0]);
            Console.WriteLine("Converted to");
            Console.WriteLine(Converter.Convert(number));
            Console.ReadLine();
        }
    }
}
