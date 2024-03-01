
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        return View(); ;
    }
}
