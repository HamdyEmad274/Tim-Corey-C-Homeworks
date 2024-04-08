namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome!");
            string[] names = { "Hamdy", "Sopeh", "Abdelwahab" };
            bool exit = false;
            string answer = "";
            while (!exit)
            {
                Console.WriteLine("Choose number of name you want to print from 1 to 3");
                string numbertext = (Console.ReadLine());
                if (int.TryParse(numbertext, out int number) == (false))
                { Console.WriteLine("invalid number format, Try again!"); }
                else
                {
                    while (number > 3 || number < 1)
                    {
                        Console.WriteLine("Wrong number, Try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Your chosen name is " + names[number - 1]);
                    do
                    {
                        Console.WriteLine("Do you want to continue ? (y/n)");
                        answer = Console.ReadLine();
                        if (answer.ToLower() == "y") { exit = false; }
                        else { exit = true; }
                    } while (answer != "y" && answer != "n");
                }
            }
        }
    }
}