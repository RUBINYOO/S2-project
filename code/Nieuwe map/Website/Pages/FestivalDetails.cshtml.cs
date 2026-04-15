using DAL;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class FestivalDetailsModel : PageModel
    {
		private readonly FestivalService festivalService;
		public List<Festival> festivals { get; set; }
		public FestivalDetailsModel(IFestivalRepo festivalRepo)
		{
			festivalService = new(festivalRepo);
		}
		public void OnGet()
		{
			festivals = festivalService.GetFestivals();
		}
	}
}
