
namespace AdvancedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExceptionMethod();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"The Error says {ex.Message}");
            }
        }

        private static void ExceptionMethod()
        {
            throw new NotImplementedException("You Forgot To Complete Your Code Nigga!!");
        }
    }
}
