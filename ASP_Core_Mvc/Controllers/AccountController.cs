using ASP_Core_Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers;

public class AccountController : Controller
{
    [Route("/details")]
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        return View(viewModel);
    }
}
