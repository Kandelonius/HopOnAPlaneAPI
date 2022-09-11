using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    abstract class Ticket
    {
        protected int ticketNumber;
        protected DateTime eventTime;
        protected string ticketEvent;
        protected string seatNumber;
        protected string eventVenue;
        protected bool matinee;
        protected bool adult;
        protected decimal ticketPrice;
    }
}
