using System.ComponentModel.DataAnnotations;

namespace ASP_Core_Mvc.Models;

public class ContactUsModel
{
    [Display(Name = "Full name", Prompt = "Enter your full name", Order = 0)]
    [Required(ErrorMessage = "Invalid name")]
    public string FullName { get; set; } = null!;

    [Display(Name = "Email adress", Prompt = "Enter you Email", Order = 1)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Invalid email")]
    public string EmailAdress { get; set; } = null!;

    [Display(Name = "Service", Prompt = "Choose the service your are intrested in", Order = 2)]
    public string? Service { get; set; } 

    [Display(Name = "Message", Prompt = "Enter your message here", Order = 3)]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "You must write text..")]
    public string Message { get; set; } = null!;
}
