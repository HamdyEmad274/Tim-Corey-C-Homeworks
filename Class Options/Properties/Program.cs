namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address add = new Address("Atmida" , "MitGhamr" , "Egypt" , "1241");
            //add.FullAddress = // Gives error ReadOnly And that's the task ^_^
            Console.WriteLine(add.FullAddress);
            
        }
    }
}
