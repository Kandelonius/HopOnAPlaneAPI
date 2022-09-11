using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    abstract class Ticket
    {
        private int ticketNumber;
        private DateTime eventTime;
        private string ticketEvent;
        private string seatNumber;
        private string eventVenue;
        private bool adult;
        private decimal ticketPrice;

        protected Ticket(int ticketNumber, DateTime eventTime, string ticketEvent, string seatNumber, string eventVenue, bool adult, decimal ticketPrice)
        {
            this.TicketNumber = ticketNumber;
            this.EventTime = eventTime;
            this.TicketEvent = ticketEvent;
            this.SeatNumber = seatNumber;
            this.EventVenue = eventVenue;
            this.Adult = adult;
            this.TicketPrice = ticketPrice;
        }

        protected int TicketNumber 
        { 
            get => ticketNumber; 
            set 
            { 
                ticketNumber = (value > 0)? value : -1;
            } 
        }
        protected DateTime EventTime { get => eventTime; set => eventTime = value; }
        protected string TicketEvent { get => ticketEvent; set => ticketEvent = value; }
        protected string SeatNumber { get => seatNumber; set => seatNumber = value; }
        protected string EventVenue { get => eventVenue; set => eventVenue = value; }
        protected bool Adult { get => adult; set => adult = value; }
        protected decimal TicketPrice 
        { 
            get => ticketPrice;
            set 
            {
                ticketPrice = (value > 0) ? value : -1; 
            } 
        }
    }
}
