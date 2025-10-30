using BugStore.Handlers.Customers;

namespace BugStore.Test.Handlers.Customers;

public class CustomerHandlerTests
{
    private readonly Handler handler;

    public CustomerHandlerTests()
    {
        handler = new Handler();
    }

    [Fact]
    public void ShouldCreateCustomer()
    {
        var request = new Requests.Customers.Create
        {
            Customer = new Models.Customer
            {
                Id = Guid.NewGuid(),
                Name = "Test Customer",
                Email = "teste@teste.com",
                Phone = "1234567890",
                BirthDate = new DateTime(1990, 1, 1)
            }
        };

        var result = handler.Create(request);
        Assert.NotNull(result);
        Assert.Equal(request.Customer.Id, result!.Id);
        Assert.Equal(request.Customer.Name, result.Name);
        Assert.Equal(request.Customer.Email, result.Email);
        Assert.Equal(request.Customer.Phone, result.Phone);
        Assert.Equal(request.Customer.BirthDate, result.BirthDate);
    }

    [Fact]
    public void ShouldUpdateCustomer()
    {
        var request = new Requests.Customers.Update
        {
            Customer = new Models.Customer
            {
                Id = Guid.NewGuid(),
                Name = "Updated Customer",
                Email = "teste1@teste.com",
                Phone = "1234567891",
                BirthDate = new DateTime(1991, 1, 1)
            }
        };

        var result = handler.Update(request);
        Assert.NotNull(result);
        Assert.Equal(request.Customer.Id, result!.Id);
        Assert.Equal(request.Customer.Name, result.Name);
        Assert.Equal(request.Customer.Email, result.Email);
        Assert.Equal(request.Customer.Phone, result.Phone);
        Assert.Equal(request.Customer.BirthDate, result.BirthDate);
    }

    [Fact]
    public void ShouldDeleteCustomer()
    {
        var customerId = Guid.NewGuid();
        var request = new Requests.Customers.Delete
        {
            Id = customerId
        };

        var result = handler.Delete(request);
        Assert.NotNull(result);
        Assert.Equal(customerId, result!.Id);
    }

    [Fact]
    public void ShouldGetCustomerById()
    {
        var customerId = Guid.NewGuid();
        var request = new Requests.Customers.GetById
        {
            Id = customerId
        };

        var result = handler.GetById(request);
        Assert.NotNull(result);
        Assert.Equal(customerId, result!.Id);
    }

    [Fact]
    public void ShouldGetCustomers()
    {
        var request = new Requests.Customers.Get();

        var result = handler.Get(request);
        Assert.NotNull(result);
        Assert.Empty(result!);
    }
}
