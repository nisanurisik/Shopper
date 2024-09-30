using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopper.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Shopper.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var model = new ProductViewModel
        {
            Categories = Repository.Categories
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
        var model = new ProductViewModel
        {
            Categories = Repository.Categories,
            Product = product,
            Products = Repository.Products
        };
        return View(model);
    }
    public IActionResult Basket()
    {
        var model = new ProductViewModel
        {
            Categories = Repository.Categories,
            Products = Repository.Products
        };
        return View(model);
    }

}
