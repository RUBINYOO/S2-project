using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
	public class LoginModel : PageModel
	{
		[BindProperty]
		public InputModel Input { get; set; } = new();

		public string? ReturnUrl { get; set; }

		public class InputModel
		{
			[Required(ErrorMessage = "E-mail is verplicht")]
			[EmailAddress(ErrorMessage = "Voer een geldig e-mailadres in")]
			[Display(Name = "E-mail")]
			public string Email { get; set; } = string.Empty;

			[Required(ErrorMessage = "Wachtwoord is verplicht")]
			[DataType(DataType.Password)]
			[Display(Name = "Wachtwoord")]
			public string Password { get; set; } = string.Empty;

			[Display(Name = "Onthoud mij")]
			public bool RememberMe { get; set; }
		}

		public void OnGet(string? returnUrl = null)
		{
			ReturnUrl = returnUrl ?? Url.Content("~/");
		}

		public IActionResult OnPost(string? returnUrl = null)
		{
			ReturnUrl = returnUrl ?? Url.Content("~/");

			if (!ModelState.IsValid)
			{
				return Page();
			}

			// TODO: vervang dit door echte login-logica (bijv. via Identity of je eigen DAL)
			var loginOk = FakeLoginCheck(Input.Email, Input.Password);

			if (!loginOk)
			{
				ModelState.AddModelError(string.Empty, "Ongeldige inloggegevens.");
				return Page();
			}

			// Hier zou je de user echt aanmelden (cookie/Identity)
			// bv: await _signInManager.PasswordSignInAsync(...)

			return LocalRedirect(ReturnUrl);
		}

		private bool FakeLoginCheck(string email, string password)
		{
			// Alleen als voorbeeld:
			return email == "test@example.com" && password == "Test123!";
		}
	}
}
