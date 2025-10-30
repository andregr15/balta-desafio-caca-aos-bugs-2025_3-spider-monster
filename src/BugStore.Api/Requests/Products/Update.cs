using BugStore.Models;

namespace BugStore.Requests.Products;

public class Update
{
    public Guid Id { get; set; }
    public Product Product { get; set; } = new();
}