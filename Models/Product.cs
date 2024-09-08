using System.ComponentModel.DataAnnotations;

namespace Shopper.Models
{
  public class Product
  {

    public int ProductId { get; set; }
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Price { get; set; }

    public string? Image { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public string[]? Size { get; set; }

    public bool Stok { get; set; }

    public int? ColorId { get; set; }
    public string? Url { get; set; }
    public Color? Color { get; set; }
    public Category? Category { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();

  }
}