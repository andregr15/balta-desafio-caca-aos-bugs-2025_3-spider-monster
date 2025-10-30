using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Create
{
    public Customer? Customer { get; set; } = new();
}