using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class MessageMethods
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello and Welcome to my program");
            Console.WriteLine("*******************************");
        }
        public static string GetName()
        {
            Console.WriteLine("What is your party/club/house name ? :");
            string FirstName = Console.ReadLine();
            return FirstName;
        }
        public static int GetNumber()
        {
            int Number ;
            bool isNumber;
            do
            {
                Console.WriteLine("how many people are in your party/club/house ?");
                string Numbertext = Console.ReadLine();
                isNumber = int.TryParse(Numbertext, out Number); 
            } while (isNumber == false);
            return Number;
        }
        public static bool AskContinue() 
        {
            Console.WriteLine("Would you like to continue ? (y/n) ");
            string Continue = Console.ReadLine();
            bool output = Continue.ToLower() == "y";
            return output;
        }
        public static (List<string>  , int ) GetAllGuests()
        {
            List<string> guests = new List<string>();
            int totalGuests = 0;
            do
            { 
                guests.Add(GetName()); 
                totalGuests += GetNumber();
            } while (AskContinue());
            return (guests,totalGuests);
        }
        public static void PrintGuests(List<string> guests)
        {
            Console.WriteLine("Guests: ");
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
        public static void PrintTotalGuests(int totalGuests)
        {
            Console.WriteLine("Total guests: ");
            Console.WriteLine(totalGuests);
        }

    }
}
