using DAL;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
	public class IndexModel : PageModel
	{
		private readonly FestivalService festivalService;
		public List<Festival> festivals { get; set; }
		public IndexModel(IFestivalRepo festivalRepo)
		{
			festivalService = new(festivalRepo);
		}
		public void OnGet()
		{
			festivals = festivalService.GetFestivals();
		}
	}
}
