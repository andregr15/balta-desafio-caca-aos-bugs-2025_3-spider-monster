using src.Handlers.Orders;

namespace BugStore.Test.Handlers.Orders;

public class OrderHandlerTests
{
    private readonly Handler handler;

    public OrderHandlerTests()
    {
        handler = new Handler();
    }

    [Fact]
    public void ShouldCreateOrder()
    {
        var request = new Requests.Orders.Create
        {
            Order = new Models.Order
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Lines = []
            }
        };

        var result = handler.Create(request);
        Assert.NotNull(result);
        Assert.Equal(request.Order.Id, result!.Id);
        Assert.Equal(request.Order.CustomerId, result.CustomerId);
        Assert.Equal(request.Order.CreatedAt, result.CreatedAt);
        Assert.Equal(request.Order.UpdatedAt, result.UpdatedAt);
        Assert.Equal(request.Order.Lines, result.Lines);
    }

    [Fact]
    public void ShouldGetOrderById()
    {
        var request = new Requests.Orders.GetById
        {
            Id = Guid.NewGuid()
        };

        var result = handler.GetById(request);
        Assert.NotNull(result);
        Assert.Equal(request.Id, result!.Id);
    }
}
