using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public static class Validator
    {
        public static List<int> ValidateNumberAndReturnList(string numbers)
        {
            List<int> ticketNumbers = new List<int>();
            int number = 0;
            if (!(numbers.Length == 6))//TODO: compare with max lenght
                throw new ArgumentException("Ticket must have 6 numbers in itself!");
            foreach (char ch in numbers)
            {
                if (!int.TryParse(ch.ToString(), out number))
                    throw new FormatException("Format of numbers exception!");
                else
                    ticketNumbers.Add(number);
            }

            return ticketNumbers;
        }       
    }
}
