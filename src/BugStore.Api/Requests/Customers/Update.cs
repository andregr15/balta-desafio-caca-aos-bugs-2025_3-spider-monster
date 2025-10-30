using BugStore.Models;

namespace BugStore.Requests.Customers;

public class Update
{
    public Guid Id { get; set; }
    public Customer Customer { get; set; } = new();
}