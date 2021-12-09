using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBS.Library
{
    public class Ticket
    {
        public string Movie { get; set; }
        public DateTime Date { get; set; }
        public int Seat { get; set; }
        public int Theater { get; set; }
        public string TicketType { get; set; }
        public bool Available
        {
            get => Convert.ToInt32(Seat) > 50;
            set => Available = value;
        }
        

    }
}
