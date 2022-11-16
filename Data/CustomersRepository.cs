using Jul.Entities;
using Jul.Services;
using Microsoft.EntityFrameworkCore;

namespace Jul.Data;

public class CustomersRepository
{
    private static CustomersRepository? _instance;
    private readonly UnitOfWork _uow;

    private CustomersRepository(UnitOfWork uow)
    {
        _uow = uow;
    }

    public static CustomersRepository Create(UnitOfWork uow)
    {
        return _instance ??= new CustomersRepository(uow);
    }

    public async Task<List<Customers>> GetCustomersAsync()
    {
        return await _uow.DbContext.Customers.ToListAsync();
    }

    public async Task<Customers> GetCustomerByIdAsync(int id)
    {
        return await _uow.DbContext.Customers.SingleOrDefaultAsync(e => e.Id == id);
    }

    public async Task AddCustomerAsync(Customers customer)
    {
        await _uow.DbContext.Customers.AddAsync(customer);
    }

    public async Task AddCustomersAsync(ICollection<Customers> customers)
    {
        await _uow.DbContext.Customers.AddRangeAsync(customers);
    }
    
    
}