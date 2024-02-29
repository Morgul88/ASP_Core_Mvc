using ASP_Core_Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();
        return View(); ;
    }
}
