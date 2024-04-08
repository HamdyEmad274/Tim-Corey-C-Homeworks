namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name: ");
            string firstName = Console.ReadLine();
            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                Console.WriteLine($"Hi Professor {firstName}!");
            }
            else
            {
                Console.WriteLine("Enter Your Age: ");
                string agetext = (Console.ReadLine());
                if (int.TryParse(agetext, out int age))
                {
                    if (age < 21)
                    {
                        Console.WriteLine($"Hi {firstName}!");
                        Console.WriteLine($"Sorry you are under 21, you have to wait {21 - age} years to start this class.");
                    }
                    else
                    {
                        Console.WriteLine($"Hi {firstName}!");
                        Console.WriteLine("Welcome to this class!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            
            
        }
    }
}
