using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LuckyTickets
{
    public class TicketsCollection: IEnumerable
    {
        #region Prvt Field

        private List<Ticket> _ticketsList = new List<Ticket>();

        #endregion

        #region Indxor

        public Ticket this[int index]
        {
            get
            {
                return _ticketsList[index];
            }
        }

        #endregion

        #region Methods

        public void Add(params Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                _ticketsList.Add(tickets[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _ticketsList.GetEnumerator();
        }

        #endregion
    }
}
