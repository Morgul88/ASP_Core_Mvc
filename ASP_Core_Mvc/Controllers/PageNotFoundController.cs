using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers
{
    public class PageNotFoundController : Controller
    {
        [Route("/pagenotfound")]
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
