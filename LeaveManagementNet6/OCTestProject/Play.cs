using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    internal class Play : Ticket
    {
        private string playName;
        private bool matinee;

        public Play(int ticketNumber, DateTime eventTime, string ticketEvent, string seatNumber, string eventVenue, bool adult, decimal ticketPrice, string playName, bool matinee) : base(ticketNumber, eventTime, ticketEvent, seatNumber, eventVenue, adult, ticketPrice)
        {
            PlayName = playName;
            Matinee = matinee;
        }
        protected string PlayName { get => playName; set => playName = value; }
        protected bool Matinee { get => matinee; set => matinee = value; }
    }
}
