namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Foreach Loop!");
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter Names one by one and when finished enter \"finish\" or empty line:");
                
                string name = Console.ReadLine();
                while (name.ToLower() != "finish"&&name!="")
                {
                    names.Add(name);
                    name = Console.ReadLine();
                }
                break;

            }
            Console.WriteLine("======================================");
            Console.WriteLine("Your Names are: ");
            foreach (var n in names)
            {
                Console.Write($"{n} \t");
            }
        }
    }
}
