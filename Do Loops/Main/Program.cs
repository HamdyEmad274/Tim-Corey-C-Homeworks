namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome!");
            bool run = true;
            while (run)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                while(name == "")
                {
                    Console.WriteLine("Please enter a name");
                    name = Console.ReadLine();
                }
                if (name.ToLower() == "tim")
                {
                    Console.WriteLine("Hello Professor "+ name);
                }
                else
                {
                    Console.WriteLine("Hello Student "+ name);
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n") { run = false; }
                else { run = true; }
            }
        }
    }
}
