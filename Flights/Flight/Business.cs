using System;

namespace Flights
{
    // Class representing a business class flight, inheriting from Flight class
    public class Business : Flight
    {
        // Additional property for additional amenities in business class
        public string AdditionalAmenities { get; set; }

        // Constructor to initialize Business class flight properties
        public Business(string number, int capacity, int booked, string additionalAmenities)
        {
            Number = number;
            Capacity = capacity;
            Booked = booked;
            AdditionalAmenities = additionalAmenities;
        }

        // Method to book a ticket for Business class flight
        public override bool BookTicket()
        {
            return true;
        }

        // Method to cancel a ticket for Business class flight
        public override bool CancelTicket()
        {
            return true;
        }

        // Method to get details of the Business class flight
        public override string Details()
        {
            return $"Business Class Flight Number: {Number}, Capacity: {Capacity}, Booked Seats: {Booked}, Additional Amenities: {AdditionalAmenities}";
        }

        // Method to update status of the Business class flight
        public sealed override string UpdateStatus()
        {
            return "Business class flight status updated.";
        }

        // Method to apply discount rate to the Business class flight
        public string ApplyDiscountRate(double newRate)
        {
            return ($"Discount rate applied: {newRate}%");
        }

        // Method specific to Business class flights
        public void BusinessMethod()
        {
            // Method implementation
        }
    }
}
