using DAL;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class FestivalDetailsModel : PageModel
    {
		private readonly FestivalService festivalService;
		public Festival selectedFestival ;
		public FestivalDetailsModel(IFestivalRepo festivalRepo)
		{
			festivalService = new(festivalRepo);
		}
		public void OnGet(int id)
		{
			selectedFestival = festivalService.GetFestival(id);
		}
	}
}
