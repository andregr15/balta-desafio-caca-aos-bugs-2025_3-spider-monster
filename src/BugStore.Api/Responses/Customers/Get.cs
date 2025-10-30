using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Get
{
    public IEnumerable<Customer>? Customers { get; set; }
}