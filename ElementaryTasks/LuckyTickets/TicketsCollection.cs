using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LuckyTickets
{
    public class TicketsCollection: IEnumerable<Ticket>//Show lucky tickets(mb 10s)
    {
        #region Prvt Field

        private List<Ticket> _ticketsList = new List<Ticket>();

        #endregion

        #region Methods

        public void Add(params Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                _ticketsList.Add(tickets[i]);
            }
        }

        public IEnumerator<Ticket> GetEnumerator()
        {
            return _ticketsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ticketsList.GetEnumerator();
        }

        #endregion
    }
}
