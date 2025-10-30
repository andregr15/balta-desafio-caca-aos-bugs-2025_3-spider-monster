using BugStore.Models;
using BugStore.Requests.Products;

namespace src.Handlers.Products;

public class Handler
{
    public Product? Create(Create request)
    {
        return request.Product;
    }

    public Product? Update(Update request)
    {
        return request.Product;
    }

    public Product? Delete(Delete request)
    {
        return new Product { Id = request.Id };
    }

    public Product? GetById(GetById request)
    {
        return new Product { Id = request.Id };
    }

    public IEnumerable<Product>? Get(Get request)
    {
        return Enumerable.Empty<Product>();
    }
}
