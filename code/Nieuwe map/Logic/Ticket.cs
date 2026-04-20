using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
	public class Ticket
	{
		public string Type { get; set; }
		public decimal Price { get; set; }

		public Ticket (string type, decimal price)
		{
			Type = type;
			Price = price;
		}
	}
}
