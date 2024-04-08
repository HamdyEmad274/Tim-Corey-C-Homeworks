namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageMethods.SayHi();
            var(guests,totalGuests) = MessageMethods.GetAllGuests();
            MessageMethods.PrintGuests(guests);
            MessageMethods.PrintTotalGuests(totalGuests);

        }
    }
}
