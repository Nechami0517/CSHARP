using DO;
using DalApi;
using System.Data;
using System.Reflection;
using Tools;
using System.Linq;
namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "insert");
        foreach (Customer item2 in DataSource.customers)
        {
            if (item2.CustomerId == item.CustomerId)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                MethodBase.GetCurrentMethod().Name, "Error! Cannot add an existing customer.");

                throw new DalIdExist("לא ניתן להוסיף לקוח קיים");
            }
        }

        DataSource.customers.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, $"went out and return {item.CustomerName}");
        return item.CustomerId;


    }
    public Customer? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        
        Customer c = DataSource.customers.SingleOrDefault(c => c?.CustomerId == id);
        if (c == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "Error! Id not exist");

            throw new DalIDoesNotExist("מזהה לא קיים");
        }


        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
        MethodBase.GetCurrentMethod().Name, $"went out and return {c}");
        return c;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        if (filter != null)
        {
            return DataSource.customers.Where(s => filter(s)).ToList();
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {(DataSource.customers)}");
        return new List<Customer?>(DataSource.customers);
    }
    public void Update(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Delete(item.CustomerId);
        DataSource.customers.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
          MethodBase.GetCurrentMethod().Name, $"went out");
    }
    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Customer item = Read(id);
        if (item != null)
        {
            DataSource.customers.Remove(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
               MethodBase.GetCurrentMethod().Name, $"went out");
        }
        else
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                MethodBase.GetCurrentMethod().Name, "Error- wrong! Id is not recognize");
            throw new DalIDoesNotExist("מזהה שגוי");
        }
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {DataSource.customers.Where(s => filter(s)).First()}");
        return DataSource.customers.Where(s => filter(s)).First();
    }
}
