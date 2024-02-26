using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers
{
    public class CoursesController : Controller
    {
        [Route("/courses")]
        public IActionResult Courses()
        {
            return View();
        }

        [Route("/singlecourse")]
        public IActionResult SingleCourse()
        {
            return View();
        }
    }
}
