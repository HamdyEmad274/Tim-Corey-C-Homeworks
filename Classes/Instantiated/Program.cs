namespace Instantiated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Person> people = new List<Person>();
            string FirstName = "";
            while (FirstName.ToLower() != "quit")
            {
                Console.WriteLine("Enter a first name or 'quit' to exit: ");
                FirstName = Console.ReadLine();
                if (FirstName.ToLower() == "quit") { break; }
                Console.WriteLine("Enter a last name: ");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter a street: ");
                string Street = Console.ReadLine();
                Console.WriteLine("Enter a city: ");
                string City = Console.ReadLine();
                Console.WriteLine("Enter a Country: ");
                string Country = Console.ReadLine();
                Address address = new Address(Street, City, Country);
                Person person = new Person(FirstName, LastName,address);
                people.Add(person);
                Console.WriteLine("Person Added");
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} lives at {person.Address.Street}, {person.Address.City}, {person.Address.Country}");
            }
        }
    }
}
