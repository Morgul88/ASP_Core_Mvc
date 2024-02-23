using ASP_Core_Mvc.Models;

namespace ASP_Core_Mvc.ViewModels
{
    public class SignInViewModel
    {
        public string Title { get; set; } = "Sign in";

        public SignInModel Form { get; set; } = new SignInModel();

        public string? ErrorMessage { get; set; }

    }
}
