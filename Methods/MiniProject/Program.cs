namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> numbers = new List<int>();
            ActionMethods.Welcome();
            while (true)
            {
                Console.WriteLine("Enter Your Name: ");
                names.Add(ActionMethods.GuestName());
                Console.WriteLine("Enter Your party number: ");
                numbers.Add(ActionMethods.GuestNumber());
                Console.WriteLine("Do you want to add another guest? (y/n or empty)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n"|| answer == "") break;
            }
            Console.WriteLine("Guest List:");
            foreach (string name in names) {
                Console.WriteLine(name);
            }
            Console.WriteLine("Total number of guests: " + numbers.Sum());
        }
    }
}
