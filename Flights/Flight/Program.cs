using System;

namespace Flights
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a Domestic flight object
            Domestic domesticFlight = new Domestic("VI321", 150, 50, 20);   //created an object for Domestic class 
            // Displaying Domestic flight details
            Console.WriteLine("Domestic Flight Details:");
            // Printing details of the Domestic flight
            Console.WriteLine(domesticFlight.Details());
            // Checking and updating status of the Domestic flight
            Console.WriteLine(domesticFlight.UpdateStatus());
            // Checking if there is extra legroom available in Domestic flight
            Console.WriteLine(domesticFlight.ExtraLegroom());
            // Executing a method specific to Domestic flights
            domesticFlight.DomesticMethod();

            // Created an International flight object
            International internationalFlight = new International("A2H56", 200, 100, 30); //created an object for International class
            // Displaying International flight details
            Console.WriteLine("\n International Flight Details:");
            // Printing details of the International flight
            Console.WriteLine(internationalFlight.Details());
            // Checking and updating status of the International flight
            Console.WriteLine(internationalFlight.UpdateStatus());
            // Checking if there is lounge access available in International flight
            Console.WriteLine(internationalFlight.LoungeAccess());
            // Executing a method specific to International flights
            internationalFlight.InternationalMethod();

            // Created a Business flight object
            Business businessFlight = new Business("BK234", 100, 70, "Priority Boarding, Lounge Access"); //created an object for Business class
            // Displaying Business class flight details
            Console.WriteLine("\n Business Class Flight Details:");
            // Printing details of the Business class flight
            Console.WriteLine(businessFlight.Details());
            // Checking and updating status of the Business class flight
            Console.WriteLine(businessFlight.UpdateStatus());
            // Applying a discount rate to the Business class flight
            Console.WriteLine(businessFlight.ApplyDiscountRate(12));
            // Executing a method specific to Business class flights
            businessFlight.BusinessMethod();
        }
    }
}
