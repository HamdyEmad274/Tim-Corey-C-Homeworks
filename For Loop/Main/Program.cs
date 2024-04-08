namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the for loop");
            Console.WriteLine("Please enter a list of names separated by commas");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine($"Hello {nameList[i]}!");
            }
        }
    }
}