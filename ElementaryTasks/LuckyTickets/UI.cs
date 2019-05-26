using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public static class UI
    {
        public static void Display(int countOfLuckyTickets, string type)
        {
            Console.WriteLine($"Type of lucky tickets: {type}");
            Console.WriteLine($"Count of lucky tickets: {countOfLuckyTickets} ");
        }
    }
}
