using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBS.Library
{
    class TicketSystemOp : ITicketSystemOp
    {
        public List<Ticket> TicketList = new List<Ticket>(50);


        public void BuyTicket()
        {
            throw new NotImplementedException();
        }

        public void CheckAvailability()
        {
            var count = TicketList.Count(x => x != null && x.Available == true);
        }

        public void ChooseDateTime()
        {
            throw new NotImplementedException();
        }

        public void ChooseFromCatalog()
        {
            throw new NotImplementedException();
        }

        public void ChooseTicketType()
        {
            throw new NotImplementedException();
        }

        public string PrintTicket()
        {
            throw new NotImplementedException();
        }

        public void ChooseSeat()
        {
            throw new NotImplementedException();
        }


    }
}
