namespace WebUI.Entities;

public class Product
{

    public Product()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
}
