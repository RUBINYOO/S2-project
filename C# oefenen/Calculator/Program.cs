using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,4));

            Console.WriteLine(Subtract(5,4));

            Console.WriteLine(Devide(5.0,4.0));

            Console.WriteLine(Multiply(5,4));
		}
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract( int x, int y)
        {
            return x - y; 
        }

        static double Devide(double x, double y)
        {
            return x / y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
