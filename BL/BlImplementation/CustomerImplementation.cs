using BlApi;
using BO;
using DO;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer customer)
    {
        try
        {
            return _dal.Customer.Create(customer.Convert());
        }
        catch (DO.DalIdExist ex)
        {
            throw new BlIdExist("Customer already exists.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch(DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Customer does not exist.", ex);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            
            return _dal.Customer.Read(id).Convert();
        }
        catch (DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Customer does not exist.", ex);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(c => filter(c.Convert())).Convert();
        }
        
        catch (Exception ex)
        {
            throw new BlSystemException("Customer does not exist based on filter.", ex);
        }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filters = null)
    {
        try
        {
            var customers = _dal.Customer.ReadAll();

            if (filters != null)
            {
                customers = customers.Where(customer => filters(customer.Convert())).ToList();
            }

            return customers.Select(p => p.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to read all products.", ex);
        }
    }

    public void Update(BO.Customer item)
    {
        try
        {
            _dal.Customer.Update(item.Convert());
        }
        catch (DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("ID does not exist", ex);
        }
        catch (Exception ex)
        {
            throw new Exception (ex.Message);
        }
    }

    public bool IsExist(int id)
    {
        try
        {
            Read(id);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
