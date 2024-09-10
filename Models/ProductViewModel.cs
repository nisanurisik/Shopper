namespace Shopper.Models
{
  public class ProductViewModel
  {
    public List<Product> Products { get; set; } = null!;
    
    public List<Category> Categories { get; set; } = null!;

    public List<Color> Colors { get; set; } = null!;

    public string? SelectedCategory { get; set; }

    public Product? Product {get; set;}


  }
}