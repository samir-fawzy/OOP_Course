using System;

namespace OOP_Course.Event_Management_Sytstem
{
    internal class Events :  IBookable
    {
        public Events(string name,string date , int seats) 
        {
            Name = name;
            Date = date;
            AvailableSeats = seats;
        }
        // proberties
        public string Name {  get;protected set; }
        public string Date { get;protected set; }
        public int AvailableSeats { get;protected set; }

        // handle tickets 
        public void BookTicket(int quantity)
        {
            if (quantity > 0 && quantity <= AvailableSeats)
            {
                AvailableSeats -= quantity;
                Console.WriteLine($"{quantity} ticket(s) booked for {Name}. Remaining seats:{AvailableSeats}");
            }
            else
                Console.WriteLine("Not found available sets");
        }

        // return book price
        public virtual double CalculateTicketPrice()
        {
            return 50; // defult value
        }
    }
}
