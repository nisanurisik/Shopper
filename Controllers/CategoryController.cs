using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopper.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Shopper.Controllers;

// public class CategoryController : Controller
// {

//   public IActionResult List(string category)
//   {
//     var products = Repository.Products;
//     if (!String.IsNullOrEmpty(category) && category != "0")
//     {
//       products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
//     }
//     var model = new ProductViewModel
//     {
//       Products = products,
//       Categories = Repository.Categories,
//       Colors = Repository.Colors,
//       SelectedCategory = category
//     };
//     // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);
//     return View(model);
//   }
// }

public class CategoryController : Controller
{
  public IActionResult List(int id) // Kategori ID'sini almak için int id
  {
    var products = Repository.Products;
    if (id != 0) // Eğer kategori seçiliyse
    {
      products = products.Where(p => p.CategoryId == id).ToList();
    }

    var model = new ProductViewModel
    {
      Products = products,
      Categories = Repository.Categories,
      Colors = Repository.Colors,
      SelectedCategory = id.ToString() // Kategoriyi view'da göstermek için
    };

    return View(model);
  }
}
