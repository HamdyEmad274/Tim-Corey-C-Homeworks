
namespace AdvancedBreakPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
            if (i == 73)
                {
                    try
                    {
                        throw new Exception();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("It's the number we shouldn't face!!!");
                    }                }
            }
        }

    }
}
