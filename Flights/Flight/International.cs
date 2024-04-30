using System;

namespace Flights
{
    // Class representing an international flight, inheriting from Flight class
    public sealed class International : Flight
    {
        // Additional property for baggage allowance in international flights
        public int Baggage { get; set; }

        // Constructor to initialize International flight properties
        public International(string number, int capacity, int booked, int baggage)
        {
            Number = number;
            Capacity = capacity;
            Booked = booked;
            Baggage = baggage;
        }

        // Method to book a ticket for International flight
        public override bool BookTicket()
        {
            return true;
        }

        // Method to cancel a ticket for International flight
        public override bool CancelTicket()
        {
            return true;
        }

        // Method to get details of the International flight
        public override string Details()
        {
            return $"International Flight Number: {Number}, Capacity: {Capacity}, Booked Seats: {Booked}, Baggage Allowance: {Baggage} kg";
        }

        // Method to update status of the International flight
        public sealed override string UpdateStatus()
        {
            return "International flight status updated.";
        }

        // Method specific to International flights to indicate lounge access
        public string LoungeAccess()
        {
            return "Airport lounge access provided for international flight.";
        }

        // Method specific to International flights
        public void InternationalMethod()
        {
            // Method implementation
        }
    }
}
