using BugStore.Models;

namespace BugStore.Requests.Customers;

public class Create
{
    public Customer Customer { get; set; } = new();
}