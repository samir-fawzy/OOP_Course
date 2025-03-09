using System;


namespace OOP_Course.Flight_Booking_System
{
    internal class Fight
    {
        public Fight(string flightnumber, string destination, double price) 
        {
            FlightNumber = flightnumber;
            DestinationNumber = destination;
            Price = price;

        }

        private string FlightNumber {  get; set; }
        private string DestinationNumber { get; set; }
        private double Price { get; set; }

        protected virtual double CalculateFinalPrice(double price)
        {
            return price;
        }

        public void Main01()
        {
            Console.WriteLine("================ Fight Booking ================");

            Console.WriteLine($"Flight Number       : {FlightNumber}");
            Console.WriteLine($"Destination Number  : {DestinationNumber}");
            Console.WriteLine($"Ticket Price        : {CalculateFinalPrice(Price)}");


        }
    }
}
