using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopper.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shopper.Controllers
{
  public class CategoryController : Controller
  {
    public IActionResult List(string url)
    {
      var category = Repository.GetByUrl(url);

      var products = Repository.Products;

      if (category != null)
      {
        products = products.Where(p => p.CategoryId == category.CategoryId).ToList();
      }

      var model = new ProductViewModel
      {
        Products = products,
        Categories = Repository.Categories,
        Colors = Repository.Colors
      };

      return View(model);
    }
  }
}