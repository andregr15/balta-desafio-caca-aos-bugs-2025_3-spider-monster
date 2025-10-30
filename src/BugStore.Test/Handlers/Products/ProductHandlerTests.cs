using src.Handlers.Products;

namespace BugStore.Test.Handlers.Products;

public class ProductHandlerTests
{
    private readonly Handler handler;

    public ProductHandlerTests()
    {
        handler = new Handler();
    }

    [Fact]
    public void ShouldCreateProduct()
    {
        var request = new Requests.Products.Create
        {
            Product = new Models.Product
            {
                Id = Guid.NewGuid(),
                Title = "Test Product",
                Description = "Test Description",
                Price = 99.99m,
                Slug = "slug-test-product"
            }
        };

        var result = handler.Create(request);
        Assert.NotNull(result);
        Assert.Equal(request.Product.Id, result!.Id);
        Assert.Equal(request.Product.Title, result.Title);
        Assert.Equal(request.Product.Description, result.Description);
        Assert.Equal(request.Product.Price, result.Price);
        Assert.Equal(request.Product.Slug, result.Slug);
    }

    [Fact]
    public void ShouldGetProductById()
    {
        var request = new Requests.Products.GetById
        {
            Id = Guid.NewGuid()
        };

        var result = handler.GetById(request);
        Assert.NotNull(result);
        Assert.Equal(request.Id, result!.Id);
    }

    [Fact]
    public void ShouldUpdateProduct()
    {
        var request = new Requests.Products.Update
        {
            Product = new Models.Product
            {
                Id = Guid.NewGuid(),
                Title = "Updated Product",
                Description = "Updated Description",
                Price = 149.99m,
                Slug = "slug-updated-product"
            }
        };

        var result = handler.Update(request);
        Assert.NotNull(result);
        Assert.Equal(request.Product.Id, result!.Id);
        Assert.Equal(request.Product.Title, result.Title);
        Assert.Equal(request.Product.Description, result.Description);
        Assert.Equal(request.Product.Price, result.Price);
        Assert.Equal(request.Product.Slug, result.Slug);
    }

    [Fact]
    public void ShouldDeleteProduct()
    {
        var productId = Guid.NewGuid();
        var request = new Requests.Products.Delete
        {
            Id = productId
        };

        var result = handler.Delete(request);
        Assert.NotNull(result);
        Assert.Equal(productId, result!.Id);
    }

    [Fact]
    public void ShouldGetProducts()
    {
        var request = new Requests.Products.Get { };

        var result = handler.Get(request);
        Assert.NotNull(result);
        Assert.Empty(result!);
    }
}
