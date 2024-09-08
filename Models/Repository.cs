namespace Shopper.Models
{
  public class Repository
  {
    private static readonly List<Product> _products = new();
    private static readonly List<Category> _categories = new();
    private static readonly List<Color> _colors = new();
    static Repository()
    {
      _categories.Add(new Category { CategoryId = 1, Name = "Shoes", Url = "shoes" });
      _categories.Add(new Category { CategoryId = 2, Name = "Sweatshirt", Url = "sweatshirt" });

      _colors.Add(new Color { ColorId = 1, ColorName = "White" });
      _colors.Add(new Color { ColorId = 2, ColorName = "Purple" });
      _colors.Add(new Color { ColorId = 3, ColorName = "Yellow" });
      _colors.Add(new Color { ColorId = 4, ColorName = "Red" });

      _products.Add(new Product
      {
        ProductId = 1,
        Name = "Leather mid-heel Sandals",
        Description = "Güzel Ayakkabı",
        Price = "$50",
        Image = "product-5.jpg",
        CategoryId = 1,
        Size = new string[] { "36", "37", "38" },
        Stok = true,
        ColorId = 1,
        Url = "leather-mid-heel-sandals",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 1),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
      });

      _products.Add(new Product
      {
        ProductId = 2,
        Name = "Sneakers",
        Description = "Rahat ve şık",
        Price = "$80",
        Image = "product-5.jpg",
        CategoryId = 1,
        Size = new string[] { "36", "37", "38" },
        Stok = true,
        ColorId = 2,
        Url = "sneakers",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 2),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
      });

      _products.Add(new Product
      {
        ProductId = 3,
        Name = "Sandalet",
        Description = "Rahat ve şık",
        Price = "$80",
        Image = "product-5.jpg",
        CategoryId = 2,
        Size = new string[] { "36", "37", "38" },
        Stok = true,
        ColorId = 3,
        Url = "sandalet",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 3),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
      });

      _products.Add(new Product
      {
        ProductId = 4,
        Name = "Dress",
        Description = "Rahat ve şık",
        Price = "$80",
        Image = "product-6.jpg",
        CategoryId = 2,
        Size = new string[] { "Small", "Medium", "Large" },
        Stok = true,
        ColorId = 1,
        Url = "dress",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 1),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
      });

      _products.Add(new Product
      {
        ProductId = 5,
        Name = "White Shoes",
        Description = "Rahat ve şık",
        Price = "$80",
        Image = "product-7.jpg",
        CategoryId = 1,
        Size = new string[] { "36", "37", "38" },
        Stok = true,
        ColorId = 4,
        Url = "white-shoes",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 4),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
      });

      _products.Add(new Product
      {
        ProductId = 6,
        Name = "Blous",
        Description = "Rahat ve şık",
        Price = "$80",
        Image = "product-8.jpg",
        CategoryId = 1,
        Size = new string[] { "Small", "Medium", "Large" },
        Stok = false,
        ColorId = 1,
        Url = "blous",
        Color = _colors.FirstOrDefault(cl => cl.ColorId == 1),
        Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
      });
    }

    public static List<Product> Products { get { return _products; } }

    public static void CreateProduct(Product entity)
    {
      entity.Category = _categories.FirstOrDefault(c => c.CategoryId == entity.CategoryId);
      _products.Add(entity);
    }

    public static List<Category> Categories { get { return _categories; } }
    public static List<Color> Colors { get { return _colors; } }

    public static Product? GetById(string? url)
    {
      return _products.FirstOrDefault(b => b.Url == url);
    }

    public static Category? GetByUrl(string? url)
    {
      return _categories.FirstOrDefault(c => c.Url == url);
    }
  }
}
