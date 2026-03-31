using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach loop
            Console.WriteLine("this is the aray");
            string[] fruits = { "appel", "Bannana", "Orange" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

			Console.WriteLine("this is the list");
			List<string> fruitList = new List<string>();

            fruitList.Add("Cietroen");
            fruitList.Add("pinda");

            foreach (string fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
