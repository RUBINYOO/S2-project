using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
	public interface IFestivalRepo
	{
		public List<Festival> GetAllFestivals();

		public Festival GetFestivalById(int id);

	}
}
