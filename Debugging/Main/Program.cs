namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("Enter number to multiply it: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (
                int i = 0; i < 10; i++)
            {
                
                total = number *= 5;
                Console.WriteLine($"Total now is : {total}");
            }

            Console.WriteLine($"Final Total is : {total}");
        }
    }
}
