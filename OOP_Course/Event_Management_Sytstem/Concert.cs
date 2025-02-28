namespace OOP_Course.Event_Management_Sytstem
{
    internal class Concert : Events
    {
        public Concert(string name,string date,int seats) : base(name,date, seats)
        { }
        public override double CalculateTicketPrice()
        {
            return 100;
        }
    }
}
