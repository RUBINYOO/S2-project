using DAL;
using Logic.Interfaces;
using Logic.Models;
using Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
	public class IndexModel : PageModel
	{
		private readonly FestivalService _festivalService;
		public List<Festival> festivals { get; set; }
		public IndexModel(IFestivalRepo festivalRepo)
		{
			_festivalService = new(festivalRepo);
		}
		[BindProperty(SupportsGet = true)]
		public string Search { get; set; }

		public async Task<IActionResult> OnGet()
		{
			festivals = _festivalService.GetFestivals();

			if (!string.IsNullOrWhiteSpace(Search))
			{
				festivals = festivals
					.Where(f => f.Name.Contains(Search, StringComparison.OrdinalIgnoreCase))
					.OrderBy(f => f.Name.StartsWith(Search, StringComparison.OrdinalIgnoreCase) ? 0 : 1)
					.ThenBy(f => f.Name)
					.ToList();
			}

			return Page();
		}
		
	}
}
