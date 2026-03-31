using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            int age = Convert.ToInt32(Console.ReadLine());

            int minimumAge = age / 2 + 7;

            Console.WriteLine("Your minimum age is: " + minimumAge);

        }    
    }
}
