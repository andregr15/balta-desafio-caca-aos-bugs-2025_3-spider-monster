using BugStore.Models;
using BugStore.Requests.Customers;

namespace BugStore.Handlers.Customers;

public class Handler
{
    public Customer? Create(Create request)
    {
        return request.Customer;
    }

    public Customer? Update(Update request)
    {
        return request.Customer;
    }

    public Customer? Delete(Delete request)
    {
        return new Customer { Id = request.Id };
    }


    public Customer? GetById(GetById request)
    {
        return new Customer { Id = request.Id };
    }

    public IEnumerable<Customer>? Get(Get request)
    {
        return Enumerable.Empty<Customer>();
    }
}