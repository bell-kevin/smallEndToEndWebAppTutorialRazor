using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class WelcomeModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void OnGet(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
