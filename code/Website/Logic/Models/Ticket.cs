using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
	public class Ticket
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }

		public Ticket (int id, string type, decimal price)
		{
			Id = id;
			Type = type;
			Price = price;
		}
	}
}
