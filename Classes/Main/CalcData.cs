using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class CalcData
    {
        public static double opertor(double a, double b , char op)
        {
            switch (op)
            {
                case '+':
                    return Add(a, b);
                    break;
                case '-':
                    return Sub(a, b);
                    break;
                case '*':
                    return Mul(a, b);
                    break;
                case '/':
                    return Div(a, b);
                    break;
                default:
                    Console.WriteLine("Error");
                    return 0;
            }  

        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
