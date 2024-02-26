using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers
{
    public class ContactController : Controller
    {
        [Route("/contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
