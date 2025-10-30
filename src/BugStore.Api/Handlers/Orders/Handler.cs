using BugStore.Models;
using BugStore.Requests.Orders;

namespace src.Handlers.Orders;

public class Handler
{
    public Order? Create(Create request)
    {
        return request.Order;
    }

    public Order? GetById(GetById request)
    {
        return new Order { Id = request.Id };
    }
}
