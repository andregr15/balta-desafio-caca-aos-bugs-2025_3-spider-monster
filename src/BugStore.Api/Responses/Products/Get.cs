using BugStore.Models;

namespace BugStore.Responses.Products;

public class Get
{
    public IEnumerable<Product>? Products { get; set; }
}