using GuestBookLibrary.Model;

namespace GuestBook
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            AddGuestToList();
            DisplayGuests();
            displayGuestsNumber();        
        }
        private static void AddGuestToList()
        {
            string areThereMore = "";
            int totalGuests = 0;
            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("What is your first name:");
                guest.FirstName = Console.ReadLine();
                Console.Write("What is your last name:");
                guest.LastName = Console.ReadLine();
                totalGuests++;
                guest.Companies = isGuestsNumber();
                totalGuests += guest.Companies;
                Console.Write("What is your Message to the host : ");
                guest.MessageToHost = Console.ReadLine();
                guests.Add(guest);
                Console.Write("Are there more guests coming? (yes/no):");
                areThereMore = Console.ReadLine();
                Console.Clear();
            } while (areThereMore.ToLower() == "yes");
        }
        private static void DisplayGuests()
        {
            foreach (var guest in guests)
            {
                Console.WriteLine(guest.Guestinfo);
            }            
        }
        private static void displayGuestsNumber()
        {
            int totalguests = getGuestsNumber();
            Console.WriteLine($"Total Guests: {totalguests}");
        }
        private static int getGuestsNumber()
        {
            int totalguests = 0;
            foreach (var guest in guests)
            {
                totalguests += guest.Companies;
            }
            totalguests += guests.Count;
            return totalguests;
        }
        private static int isGuestsNumber()
        {
            bool flag;
            int Compaines = 0;
            do
            {
                Console.Write("How many are with you:");
                if (int.TryParse(Console.ReadLine(), out  Compaines))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Please enter a number");
                }
            }
            while (flag);
            return Compaines;
        }
    }
}
