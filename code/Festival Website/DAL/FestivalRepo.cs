using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Logic;

namespace DAL
{
	public class FestivalRepo : IFestivalRepo
	{
		public List<Festival> GetAllFestivals()
		{
			List<Festival> Festivals = new List<Festival>();

			Festivals.Add(new Festival(
				1,
				"Rebirth",
				new DateOnly(2025, 5, 5),
				new TimeOnly(12, 00),
				new TimeOnly(00, 00),
				"Location 1",
				"Haaren",
				"Genre 1",
				"Description 1",
				new List<Ticket>
				{
					new Ticket("Early Bird", 7.66m),
					new Ticket("Regular", 12.50m),
					new Ticket("VIP", 25.00m)
				},
				new List<string>
				{
					"Artiest1",
					"Artiest2"
				},
				"Link 1"
			));

			Festivals.Add(new Festival(
				2,
				"Intens",
				new DateOnly(2025, 5, 5),
				new TimeOnly(12, 00),
				new TimeOnly(00, 00),
				"Location 2",
				"Moergestel",
				"Genre 2",
				"Description 2",
				new List<Ticket>
				{
					new Ticket("Early Bird", 7.66m),
					new Ticket("Regular", 15.00m)
				},
				new List<string>
				{
					"Artiest1",
					"Artiest2"
				},
				"Link 1"
			));

			Festivals.Add(new Festival(
				3,
				"Defqon.1",
				new DateOnly(2025, 6, 27),
				new TimeOnly(12, 00),
				new TimeOnly(23, 59),
				"huisken 6",
				"Biddinghuizen",
				"Hardstyle",
				"Het grootste hardstyle festival van Nederland.",
				new List<Ticket>
				{
					new Ticket("Friday", 12.50m),
					new Ticket("Saturday", 17.50m),
					new Ticket("Weekend", 29.99m)
				},
				new List<string>
				{
					"D-Block & S-te-Fan",
					"Ran-D"
				},
				"Link 3"
			));

			Festivals.Add(new Festival(
				4,
				"Awakenings",
				new DateOnly(2025, 7, 5),
				new TimeOnly(12, 00),
				new TimeOnly(23, 00),
				"Weger 4",
				"Hilvarenbeek",
				"Techno",
				"Iconisch technofestival met meerdere stages.",
				new List<Ticket>
				{
					new Ticket("Dayticket", 9.99m),
					new Ticket("VIP", 19.99m)
				},
				new List<string>
				{
					"Amelie Lens",
					"Adam Beyer"
				},
				"Link 4"
			));

			Festivals.Add(new Festival(
				5,
				"Mysteryland",
				new DateOnly(2025, 8, 23),
				new TimeOnly(11, 00),
				new TimeOnly(23, 00),
				"Haarlemmermeer",
				"Haarlemmermeer",
				"EDM",
				"Een van de oudste dancefestivals ter wereld.",
				new List<Ticket>
				{
					new Ticket("Saturday", 11.75m),
					new Ticket("Sunday", 11.75m),
					new Ticket("Weekend", 20.00m)
				},
				new List<string>
				{
					"Martin Garrix",
					"Nicky Romero"
				},
				"Link 5"
			));

			Festivals.Add(new Festival(
				6,
				"Decibel Outdoor",
				new DateOnly(2025, 8, 16),
				new TimeOnly(12, 00),
				new TimeOnly(23, 59),
				"hopie 2",
				"Hilvarenbeek",
				"Hardstyle",
				"Hardstyle festival met enorme outdoor stages.",
				new List<Ticket>
				{
					new Ticket("Dayticket", 10.25m),
					new Ticket("VIP", 18.00m)
				},
				new List<string>
				{
					"B-Front",
					"Frequencerz"
				},
				"Link 6"
			));

			Festivals.Add(new Festival(
				7,
				"Solar Weekend",
				new DateOnly(2025, 8, 1),
				new TimeOnly(12, 00),
				new TimeOnly(23, 00),
				"Kaas 3",
				"Roermond",
				"Mixed",
				"Creatief festival met kunst, muziek en cultuur.",
				new List<Ticket>
				{
					new Ticket("Dayticket", 8.50m),
					new Ticket("Weekend", 14.00m)
				},
				new List<string>
				{
					"Kensington",
					"Chef'Special"
				},
				"Link 7"
			));

			return Festivals;

		}

		public Festival GetFestivalById(int id)
		{
			List<Festival> festivals = GetAllFestivals();
			return festivals.FirstOrDefault(equals => equals.Id == id);
		}
	}
}
	