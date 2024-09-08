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
        // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);
        return View(model);
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("Index", "Home");
        }
        var bootcamp = Repository.GetById(id);

        return View(bootcamp);
    }
}

