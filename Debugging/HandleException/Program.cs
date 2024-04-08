namespace HandleException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Console Application with a for loop that throws an exception after five iterations , Catch the exception.
            int[] arr = new int[5];
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    arr[i] = i;
                    Console.WriteLine(arr[i]);
                }
                catch ( Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}
