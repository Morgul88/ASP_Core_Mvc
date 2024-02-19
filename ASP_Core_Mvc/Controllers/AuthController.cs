using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }
}
