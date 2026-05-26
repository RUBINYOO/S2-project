using System;
using System.Collections.Generic;
using System.Text;
using Logic.Models;

namespace Logic.Interfaces
{
	public interface IFestivalRepo
	{
		public List<Festival> GetAllFestivalsByDate();

		public Festival GetFestivalById(int id);

		public Festival GetFestivalByDate(DateTime date);

	}
}
