using System;

namespace Flights
{
    // Class representing a domestic flight, inheriting from Flight class
    public sealed class Domestic : Flight
    {
        // Additional property for baggage allowance
        public int Baggage { get; set; }

        // Constructor to initialize Domestic flight properties
        public Domestic(string number, int capacity, int booked, int baggage)
        {
            Number = number;
            Capacity = capacity;
            Booked = booked;
            Baggage = baggage;
        }

        // Method to book a ticket for Domestic flight
        public override bool BookTicket()
        {
            return true;
        }

        // Method to cancel a ticket for Domestic flight
        public override bool CancelTicket()
        {
            return true;
        }

        // Method to get details of the Domestic flight
        public override string Details()
        {
            return $"Domestic Flight Number: {Number}, Capacity: {Capacity}, Booked Seats: {Booked}, Baggage Allowance: {Baggage} kg";
        }

        // Method to update status of the Domestic flight
        public sealed override string UpdateStatus()
        {
            return "Domestic flight status updated.";
        }

        // Method specific to Domestic flights to apply extra legroom
        public string ExtraLegroom()
        {
            return "Extra legroom applied for domestic flight.";
        }

        // Method specific to Domestic flights
        public void DomesticMethod()
        {
            // Method implementation
        }
    }
}
