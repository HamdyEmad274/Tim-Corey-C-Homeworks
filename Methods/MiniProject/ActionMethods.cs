using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class ActionMethods
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello to Guests Book app!");
        }
        public static string GuestName()
        {
            string name=Console.ReadLine();
            return name;
        }
        public static int  GuestNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        }

    }
