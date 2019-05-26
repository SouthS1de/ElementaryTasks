using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public static class Validator
    {
        public static bool IsValidNumber(string number)
        {
            bool result = false;
            if (number.ToCharArray().Length == 6)
                result = true;
            else
                throw new ArgumentException("Ticket must have 6 numbers in itself!");
            foreach (char ch in number.ToCharArray())
            {
                if (int.TryParse(ch.ToString(), out int num))
                    result = true;
                else
                    throw new FormatException("Format of numbers exception!");
            }

            return result;
        }

        public static string IsValidLuckyTicketsType(string validatedType)
        {
            if (validatedType == "MOSKOW" || validatedType == "PITER")
            {
                Console.WriteLine("The type was correct!");
                return validatedType;
            }
            else
                throw new FormatException("Unsucessful type of lucky tickets!");
        }
    }
}
