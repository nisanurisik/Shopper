using Microsoft.AspNetCore.Mvc;
using Shopper.Models;

namespace Shopper.ViewComponents
{
  public class UserMenu : ViewComponent
  {
    public IViewComponentResult Invoke()
    {
      return View();
    }
  }
}