using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class RequestData
    {
        public static string GetName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static double GetNumber(string messeage)
        {
            Console.Write(messeage);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public static char GetOperator()
        {
            Console.Write("Enter your operator: ");
            char op = Convert.ToChar(Console.ReadLine());
            return op;
        }
    }
}
