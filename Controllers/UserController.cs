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

    public IActionResult Wishlist()
    {
      var model = new ProductViewModel
      {
        Products = Repository.Products,
        Categories = Repository.Categories
      };

      return View(model);
    }
    public IActionResult PersonalInfo()
    {
      var model = new ProductViewModel
      {
        Products = Repository.Products,
        Categories = Repository.Categories
      };

      return View(model);
    }

    public IActionResult Adresses()
    {
      var model = new ProductViewModel
      {
        Products = Repository.Products,
        Categories = Repository.Categories
      };

      return View(model);
    }
    public IActionResult Payment()
    {
      var model = new ProductViewModel
      {
        Products = Repository.Products,
        Categories = Repository.Categories
      };

      return View(model);
    }

    public IActionResult Login()
    {
      var model = new ProductViewModel
      {
        Products = Repository.Products,
        Categories = Repository.Categories
      };

      return View(model);
    }
  }
}