using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaasje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            int age = Convert.ToInt32(Console.ReadLine());

            //if
            if (age < 18)
            {
                Console.WriteLine("Your ticket price is $5");
            }
            //else if
            else if (age > 65 && age <2000)
            {
                Console.WriteLine("You are a senior, your ticket is $20");
            }

            else if (age > 2000)
            {
				Console.WriteLine("You are to old!");
			}

            //else
            else
            {
                Console.WriteLine("Your a adult, your ticket is $10");
            }
        }
    }
}
