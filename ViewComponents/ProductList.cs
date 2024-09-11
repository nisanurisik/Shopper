using Microsoft.AspNetCore.Mvc;
using Shopper.Models;

namespace Shopper.ViewComponents
{
  public class ProductList : ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      var products = Repository.Products;
      return View(products);
    }
  }
}