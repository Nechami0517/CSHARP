using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "insert");
        Product p = item with { ProductId = DataSource.Config.GetCodeProduct };
        DataSource.products.Add(p);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, $"went out and return {p.ProductId}");
        return p.ProductId;
    }
    public Product? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        var read = (from item in DataSource.products
                   where item.ProductId == id
                   select item).FirstOrDefault();
        if (read == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "Error! Id not exist.");

            throw new DalIDoesNotExist("מזהה לא קיים");
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {read}");
        return read;
    }


    public List<Product?> ReadAll(Func<Product, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        if (filter != null)
        {
            return DataSource.products.Where(s => filter(s)).ToList();
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {(DataSource.products)}");
        return new List<Product?>(DataSource.products);
    }
    public void Update(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Delete((int)item.ProductId);
        DataSource.products.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
          MethodBase.GetCurrentMethod().Name, $"went out");
    }
    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Product item = Read(id);
        if (item != null)
            DataSource.products.Remove(item);
        else
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "Error! wrong Id");

            throw new DalIDoesNotExist("מזהה שגוי");

        }
    }
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {DataSource.products.Where(s => filter(s)).First()}");
        return DataSource.products.Where(s => filter(s)).First();
    }
}
