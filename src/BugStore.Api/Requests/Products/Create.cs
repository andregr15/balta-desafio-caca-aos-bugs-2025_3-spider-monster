using BugStore.Models;

namespace BugStore.Requests.Products;

public class Create
{
    public Product Product { get; set; } = new();
}