using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Models;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Username { get; set; } = "";

    [BindProperty]
    public string Password { get; set; } = "";

    public string? ErrorMessage { get; set; }

    public IActionResult OnPost()
    {
        if (Username == "admin" && Password == "admin")
        {
            UserSession.IsAuthenticated = true;
            UserSession.Role = "Admin";
            return RedirectToPage("/Index");
        }

        if (Username == "user" && Password == "user")
        {
            UserSession.IsAuthenticated = true;
            UserSession.Role = "User";
            return RedirectToPage("/Index");
        }

        ErrorMessage = "Utilizator sau parolă greșită";
        return Page();
    }
}