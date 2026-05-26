using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Services
{
	public class FestivalService
	{
		IFestivalRepo festivalRepo;
		public FestivalService(IFestivalRepo festivalRepo)
		{
			this.festivalRepo = festivalRepo;
		}
		public List<Festival> GetFestivals()
		{
			return festivalRepo.GetAllFestivalsByDate();
		}

		public Festival GetFestival(int id)
		{
			return festivalRepo.GetFestivalById(id);
		}

		public Festival GetFestivalByDate(DateTime date)
		{
			return festivalRepo.GetFestivalByDate(date);
		}
	}
}
