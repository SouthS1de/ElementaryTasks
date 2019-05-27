using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "ticketsList1.txt";

            Console.WriteLine("Input type of lucky tickets to count (Moskow / Piter):");
            try
            {
                string typeOfLuckyTickets = Validator.IsValidLuckyTicketsType(Console.ReadLine().ToUpper());
                TicketsCollection myTicketsList = new TicketsCollection();

                using (StreamReader sr = new StreamReader(path))
                {
                    string buffer = sr.ReadLine();
                    while (buffer != null)
                    {
                        if (Validator.IsValidNumber(buffer))                        
                            myTicketsList.Add(new Ticket(buffer.ToCharArray()));
                                               
                        buffer = sr.ReadLine();
                    }
                }
                Console.Clear();
                UI.Display(CountOfLuckyTickets(myTicketsList, typeOfLuckyTickets), typeOfLuckyTickets);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
    
            Console.ReadLine();
        }

        #region Method

        public static int CountOfLuckyTickets(TicketsCollection ticketsList, string type)
        {
            int counter = 0;

            if (type == "MOSKOW")
            {
                foreach (IMoskow myTicket in ticketsList)
                {
                    if (myTicket.IsLucky())
                        counter++;
                }
            }

            if (type == "PITER")
            {
                foreach (IPiter myTicket in ticketsList)
                {
                    if (myTicket.IsLucky())
                        counter++;
                }
            }
          
            return counter;
        }

        #endregion
    }
}
