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


        public delegate int OpDelegate(int a, int b);

        static void Main(string[] args)
        {
            if (args.Length != 3 )
            {
                Console.WriteLine("ERROR: should pass 3 args.\n\tusage: calculator <a> <operator> <b>");
                return;
     
            }


            int a = int.Parse(args[0]);
            int b = int.Parse(args[2]);

            OpDelegate op = Mul;
            switch(args[1]) {
                case "+":
                    op = Add;
                    break;
                case "-":
                    op = Sub;
                    break;
                case "*":
                    op = Mul;
                    break;
                case "/":
                    Console.WriteLine(Div(a, b));
                    return;
            }
            Console.WriteLine(op(a, b));
        }
    }
}
