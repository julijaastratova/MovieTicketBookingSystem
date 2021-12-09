using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBS.Library
{
    class FillTicketList
    {
        public static void FillTicket()
        {
            DateTime dt = new DateTime(2022, 1, 1);
            for(int i = 1; i <=50; i++)
            {
                var ticket = new Ticket();
                ticket.Available = true;
                ticket.Movie = "Fight Club";
                ticket.Date = dt;
                ticket.Seat = i;
            }
        }
    }
}
