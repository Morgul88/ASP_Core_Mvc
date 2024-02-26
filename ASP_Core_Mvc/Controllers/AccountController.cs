using ASP_Core_Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Mvc.Controllers;

public class AccountController : Controller
{
    [Route("/details")]
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        //viewModel.BasicInfo = _accountService.GetBasicInfo();
        //viewModel.AdressInfoModel = _accountService.GetAdressInfo();

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveBasicInfo(viewModel.BasicInfo);
        return RedirectToAction(nameof(Details));
    }

    [HttpPost]
    public IActionResult AdressInfoModel(AccountDetailsViewModel viewModel)
    {
        //*accountService.SaveAdressInfo(viewModel.AdressInfoModel);*/
        return RedirectToAction(nameof(Details));
    }

    [Route("/security")]
    public IActionResult Security()
    {
        var viewModel = new AccountDetailsViewModel();
        return View(viewModel);
    }

    [Route("/savedcourses")]
    public IActionResult SavedItems()
    {
        var viewModel = new AccountDetailsViewModel();
        return View(viewModel);
    }
}
