using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class Ticket: IMoskow, IPiter
    {
        #region Prop
        public char[] Number { get; set; }       

        #endregion

        #region Ctor

        public Ticket(char[] number)
        {
            Number = number;
        }

        #endregion

        #region Methods

        bool IMoskow.IsLucky()
        {
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < Number.Length; i++)
            {
                if (i < 3)
                    firstSum += Convert.ToInt32(Number[i]);
                else
                    secondSum += Convert.ToInt32(Number[i]);
            }

            return firstSum == secondSum;
        }

        bool IPiter.IsLucky()
        {
            int evenSum = 0;
            int oddSum  = 0;

            for (int i = 0; i < Number.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    evenSum += Convert.ToInt32(Number[i]);
                else
                    oddSum += Convert.ToInt32(Number[i]);
            }

            return evenSum == oddSum;
        }

        #endregion
    }
}
