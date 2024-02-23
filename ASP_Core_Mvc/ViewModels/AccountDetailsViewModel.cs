using ASP_Core_Mvc.Models;

namespace ASP_Core_Mvc.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";

    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "/images/avatar.svg",
        FirstName = "Henrik",
        LastName = "Starander",
        EmailAdress = "Henrik@domain.com"

    };

    public AccountDetailAdressInfoModel AdressInfoModel { get; set; } = new AccountDetailAdressInfoModel();


}
