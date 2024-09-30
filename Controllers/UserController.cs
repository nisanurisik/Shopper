using Microsoft.AspNetCore.Mvc;
using Shopper.Models;

namespace Shopper.Controllers
{
  public class UserController : Controller
  {
    public IActionResult Order()
    {
      var model = new ProductViewModel
      {
        Categories = Repository.Categories,
      };
      return View(model);
    }
  }
}