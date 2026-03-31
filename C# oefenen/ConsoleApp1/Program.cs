using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string[] food = new string[];

			//food[0] = "Kaas";
			//food[1] = "Hamburger";
			//food[2] = "Pinda";
			//food[3] = "Vlees";

			List<string> food = new List<string>();

			food.Add(Console.ReadLine());
			food.Add(Console.ReadLine());
			food.Add(Console.ReadLine());

			foreach (string item in food)
			{
				Console.WriteLine(food[2]);
			}


		}
	}
}
