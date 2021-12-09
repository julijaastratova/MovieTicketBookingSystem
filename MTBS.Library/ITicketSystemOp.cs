using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBS.Library
{
    interface ITicketSystemOp
    {
        public void ChooseFromCatalog();
        public void ChooseDateTime();
        public void ChooseSeat();
        public void ChooseTicketType();
        public void CheckAvailability();
        public void BuyTicket();
        public string PrintTicket();


    }
}
