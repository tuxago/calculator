using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
        
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Floor(int a, int b)
        {
            return a / b;
        }

        public static float Div(float a, int b)
        {
            return a / b;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Hello World. {0} {1} {2} {3}", Add(1, 2), Sub(1, 2), Mul(2, 4), Div(3, 2));
            Console.ReadKey();
        }
    }
}
