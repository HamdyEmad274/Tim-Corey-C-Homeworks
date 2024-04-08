namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Dictionary!");
            Console.WriteLine("Enter some id and names to store them in the dictionary : ");
            Dictionary<int, string> employee = new Dictionary<int, string>();
            int id;
            string name;
            while (true)
            {
                Console.WriteLine("Enter id : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name : ");
                name = Console.ReadLine();
                employee[id] = name;
                Console.WriteLine("Do you want to continue (y/n) : ");
                if (Console.ReadLine() == "n") { break; }
                else { continue; }
            }
            do {
                Console.WriteLine("Enter id to display name : ");
                if (int.TryParse(Console.ReadLine(), out int i)) {
                    Console.WriteLine(employee[i]);
                }
                else { Console.WriteLine("Invalid input"); }
                Console.WriteLine("Do you want to continue (y/n) : ");
                if (Console.ReadLine().ToLower() == "n") { break; }
                else { continue; }
            } while (true);
            }

    }
}
