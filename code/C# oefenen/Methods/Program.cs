using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to repeat myself");

            Console.ReadKey();

            for (int i = 0; i < 5; i++)
            {
                PressEnterToRepeat();

			}
		}
        static void PressEnterToRepeat()
        {
			Console.WriteLine("You pressed enter");
			Console.WriteLine("Press enter to repeat myself");
			Console.ReadKey();
		}
    }
}
