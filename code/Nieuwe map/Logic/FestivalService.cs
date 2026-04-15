using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
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
			return festivalRepo.GetAllFestivals();
		}
	}
}
