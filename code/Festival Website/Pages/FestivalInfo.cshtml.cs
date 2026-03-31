using Festival_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Festival_Website.Pages
{
    public class FestivalInfoModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public FestivalInfoModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Festival> Festivals { get; set; }
        public void OnGet()
        {
        }
    }
}
