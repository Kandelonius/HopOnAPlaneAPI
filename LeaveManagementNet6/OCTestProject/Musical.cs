using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    internal class Musical : Ticket
    {
        private string composerName;
        private string highlightPerformer;

        public Musical(int ticketNumber, DateTime eventTime, string ticketEvent, string seatNumber, string eventVenue, bool adult, decimal ticketPrice, string composerName, string highlightPerformer) : base(ticketNumber, eventTime, seatNumber, eventVenue, adult, ticketPrice)
        {
            base.TicketEvent = "Musical";
            ComposerName = composerName;
            HighlightPerformer = highlightPerformer;
        }

        public string ComposerName { get => composerName; set => composerName = value; }
        public string HighlightPerformer { get => highlightPerformer; set => highlightPerformer = value; }
        public string GetEvent
        {
            get => base.TicketEvent;
        }
        public override string ToString()
        {
            return ($"You are going to see a {base.TicketEvent} featuring {HighlightPerformer} at {base.EventVenue} venue, proceed to seat #{base.SeatNumber}");
        }
    }
}
