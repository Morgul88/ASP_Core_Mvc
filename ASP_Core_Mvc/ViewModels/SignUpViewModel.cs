using Infrastructure.Models;

namespace ASP_Core_Mvc.ViewModels;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign up";

    public SignUpModel Form { get; set; } = new SignUpModel();
    
}
