namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Lists!");
            Console.WriteLine("Enter As many names as you want and empty line to end , I will add them to a list and tell you the total number of names");
            List<string> names = new List<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("The total number of names now is " + names.Count);
                    Console.WriteLine("The names are : ");
                    foreach (string n in names)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                }
                names.Add(name);
                Console.WriteLine("The last total number of names is " + names.Count);
            }
        }
    }
}
