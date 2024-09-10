using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopper.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Shopper.Controllers;

public class HomeController : Controller
{

    public IActionResult Index(string category)
    {
        var products = Repository.Products;
        if (!String.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        var model = new ProductViewModel
        {
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };

        return View(model);
    }

    public IActionResult Details(string? url)
    {
        if (url == null)
        {
            return RedirectToAction("Index", "Home");
        }
        var product = Repository.GetById(url);
var model = new ProductViewModel{
    Categories = Repository.Categories,
    Product = product
};
        return View(model);
    }
}
