using WebUI.Entities;

namespace WebUI.Data;

public class ProductDataSeeder
{
    private static List<Product> Products = new()
    {
        new Product()
        {
            Name = "Computer",
            Quantity = 1,
            Amount = 2,
        },

        new Product()
        {
            Name = "Monitor",
            Quantity = 2,
            Amount = 4,
        }
    };

    public static List<Product> GetAllProducts() => Products;

    public static Product GetProductById(Guid id)
    {
        return Products.FirstOrDefault(p => p.Id == id);
    }
}
