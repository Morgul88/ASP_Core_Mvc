using ASP_Core_Mvc.Models;

namespace ASP_Core_Mvc.ViewModels;

public class ContactUsViewModel
{
    public string Title { get; set; } = "Contact Us";

    public ContactUsModel Form { get; set; } = new ContactUsModel();

    public string? ErrorMessage { get; set; }

    public string? MessageSucceded { get; set; } 
}
