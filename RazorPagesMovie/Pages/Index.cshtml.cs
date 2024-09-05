using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq; // Required for LINQ queries
using RazorPagesMovie.Data; 
using RazorPagesMovie.Models; 

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context; // DbContext

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context; // Initialize the DbContext
        }

        [BindProperty]
        public string Email { get; set; } // Property for email input

        [BindProperty]
        public string Password { get; set; } // Property for password input

        public void OnGet()
        {
            // This method is called on GET requests
        }

        public IActionResult OnPostLogin()
        {
            // Check if the user exists in the database
            var user = _context.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (user != null)
            {
                // Redirect to welcome page
                return RedirectToPage("Welcome", new { firstName = user.FirstName, lastName = user.LastName });
            }

            // Handle login failure (optional)
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page(); // Return to the same page with the error message
        }
    }
}
