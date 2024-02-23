using System.ComponentModel.DataAnnotations;

namespace ASP_Core_Mvc.Models
{
    public class SignInModel
    {

        [Display(Name = "Email adress", Prompt = "Enter you Email", Order = 0)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Invalid email")]
        public string EmailAdress { get; set; } = null!;

        [Display(Name = "Password", Prompt = "Enter you password", Order = 1)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid Password")]
        public string Password { get; set; } = null!;

        [Display(Name = "Remember me", Order = 2)]
        public bool RememberMe { get; set; }
    }
}
