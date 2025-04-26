
using BO;

namespace BlApi;

public interface ICustomer
{
    bool IsExist (int  id);
    int Create(Customer customer);
    Customer? Read(int id);
    List<Customer?> ReadAll(Func<Customer, bool>? filters = null);
    void Update(Customer item);
    void Delete(int id);
    Customer? Read(Func<Customer, bool> filter);
}
