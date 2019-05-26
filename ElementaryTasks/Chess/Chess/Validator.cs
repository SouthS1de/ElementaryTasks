using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class Validator
    {
        private const int MAX_VALUE = 30;

        public static bool IsValidArgs(string[] args, ref int rows, ref int colomns)
        {
            if (args.Length == 0)
                throw new ArgumentException("Please input rows and colomns!");
            if (args.Length != 2)
                throw new FormatException("Unsuccessful format. You must write only two arguments!");
            else
            {
                if (int.TryParse(args[0], out rows) && int.TryParse(args[1], out colomns))
                {
                    if (rows > 0 && colomns > 0 && rows <= MAX_VALUE && colomns <= MAX_VALUE)
                        return true;
                    else
                        throw new ArgumentException("Rows or colomns out of range");
                }
                else
                    throw new ArgumentException("Can't parse rows or colomns");
            }
        }
    }
}
