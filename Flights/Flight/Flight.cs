using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights
{
    // Base class representing a flight
    public abstract class Flight
    {
        // Flight number
        public string Number { get; set; }
        // Total capacity of the flight
        public int Capacity { get; set; }
        // Number of booked seats
        public int Booked { get; set; }

        // Abstract method to book a ticket
        public abstract bool BookTicket();
        // Abstract method to cancel a ticket
        public abstract bool CancelTicket();
        // Abstract method to get flight details
        public abstract string Details();
        // Virtual method to update flight status
        public virtual string UpdateStatus()
        {
            return "Flight status updated.";
        }

        // Method to increase flight capacity
        public void IncreaseCapacity(int newCapacity)
        {
            Capacity = newCapacity;
        }
    }
}
