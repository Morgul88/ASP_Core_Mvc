using ASP_Core_Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers
{
    public class ContactController : Controller
    {
        [Route("/contacts")]
        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [Route("/contacts")]
        [HttpPost]
        public IActionResult Contacts(ContactUsViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            viewModel.MessageSucceded = "Message was sent.";
            return View(viewModel);


        }
    }
}
