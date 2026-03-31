using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Car
	{
		string make;
		string model;
		int year;
		string color;

		public Car(string make, string model, int year, string color)
		{
			this.make = make;
			this.model = model;
			this.year = year;
			this.color = color;
		}

		public void Drive()
		{
			Console.WriteLine("You drive a " + make + " " + model + " in " + color);
		}
	}
}
