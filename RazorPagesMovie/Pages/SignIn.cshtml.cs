using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class SignInModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public SignInModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (user != null)
            {
                return RedirectToPage("/Welcome", new { firstName = user.FirstName, lastName = user.LastName });
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }
    }
}
