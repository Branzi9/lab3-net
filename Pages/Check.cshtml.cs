using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PassGen.Pages;

public class CheckModel : PageModel
{
    private readonly ILogger<CheckModel> _logger;

    public CheckModel(ILogger<CheckModel> logger)
    {
        _logger = logger;
    }

    public List<string> GeneratedPasswords {get; set;}
    public string Message {get; set;}
    public void OnGet(string password)
    {

        GeneratedPasswords = new List<string>();
        GeneratedPasswords.Add("123456");

        
        if (Passwords.Check(password)){
            Message = "Lozinka je točna";
        }
        
        else {
            Message = "Lozinka nije točna.";
        }
    }
}
