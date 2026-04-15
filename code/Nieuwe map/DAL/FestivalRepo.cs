using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
	public class FestivalRepo : IFestivalRepo
	{
		public List<Festival> GetAllFestivals()
		{
			List<Festival> Festivals = new List<Festival>();
			Festivals.Add(new Festival(1, "Rebirth", new DateOnly(2025, 5, 5), new TimeOnly(12, 00), new TimeOnly(00, 00), "Location 1", "Genre 1", "Description 1", "Tickettype", 7.66, "Artiest1, Artiest2", "Link 1"));
			Festivals.Add(new Festival(2, "Intens", new DateOnly(2025, 5, 5), new TimeOnly(12, 00), new TimeOnly(00, 00), "Location 2", "Genre 2", "Description 2", "Tickettype", 7.66, "Artiest1, Artiest2", "Link 1"));
			Festivals.Add(new Festival(3, "Defqon.1", new DateOnly(2025, 6, 27), new TimeOnly(12, 00), new TimeOnly(23, 59), "Biddinghuizen", "Hardstyle", "Het grootste hardstyle festival van Nederland.", "Weekend", 12.50, "D-Block & S-te-Fan, Ran-D", "Link 3"));
			Festivals.Add(new Festival(4, "Awakenings", new DateOnly(2025, 7, 5), new TimeOnly(12, 00), new TimeOnly(23, 00), "Spaarnwoude", "Techno", "Iconisch technofestival met meerdere stages.", "Dayticket", 9.99, "Amelie Lens, Adam Beyer", "Link 4"));
			Festivals.Add(new Festival(5, "Mysteryland", new DateOnly(2025, 8, 23), new TimeOnly(11, 00), new TimeOnly(23, 00), "Haarlemmermeer", "EDM", "Een van de oudste dancefestivals ter wereld.", "Weekend", 11.75, "Martin Garrix, Nicky Romero", "Link 5"));
			Festivals.Add(new Festival(6, "Decibel Outdoor", new DateOnly(2025, 8, 16), new TimeOnly(12, 00), new TimeOnly(23, 59), "Beekse Bergen", "Hardstyle", "Hardstyle festival met enorme outdoor stages.", "Dayticket", 10.25, "B-Front, Frequencerz", "Link 6"));
			Festivals.Add(new Festival(7, "Solar Weekend", new DateOnly(2025, 8, 1), new TimeOnly(12, 00), new TimeOnly(23, 00), "Roermond", "Mixed", "Creatief festival met kunst, muziek en cultuur.", "Weekend", 8.50, "Kensington, Chef'Special", "Link 7"));
			return Festivals;
		}
	}
}
