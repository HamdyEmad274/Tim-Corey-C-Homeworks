using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class UserMessages
    {
        public static void Welcome(string name)
        {
            Console.Clear();
            Console.WriteLine($"Hello Mr. {name}");
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

        }
        public static void ShowResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }
        public static void GoodBye()
        {
            Console.WriteLine("GoodBye");
        }
    }
}
