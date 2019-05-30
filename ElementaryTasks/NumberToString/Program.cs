using System;

namespace NumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (int.TryParse(args[0], out num))
            {
                Console.WriteLine(Convertor.ConvertNumber(num));
            }
            
        }
    }
}
