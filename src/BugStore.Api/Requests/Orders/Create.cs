using BugStore.Models;

namespace BugStore.Requests.Orders;

public class Create
{
    public Order Order { get; set; } = new();
}