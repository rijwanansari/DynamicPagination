namespace DynamicPagination.Model;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

//sample dummy data
public class ProductService
{
    public List<Product> GetProducts()
    {
        // Sample data
        return Enumerable.Range(1, 100).Select(i => new Product
        {
            Id = i,
            Name = $"Product {i}",
            Price = i * 10
        }).ToList();
    }
}
