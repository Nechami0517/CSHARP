using DO;
using DalApi;
using System.Data;
using System.Reflection;
using Tools;
namespace Dal;

internal class SaleImplementation : ISale

{
   public int Create(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, 
            MethodBase.GetCurrentMethod().Name,"insert");
        Sale s = item with { SaleId = DataSource.Config.GetCodeSale };
           DataSource.Sales.Add(s);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, $"went out and return {s.SaleId}");
        return s.SaleId;
    }
    public Sale? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        var read = (from item in DataSource.Sales
                   where item.SaleId == id 
                   select item).FirstOrDefault();
       
        if (read == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "Error. ID not valid");

            throw new DalIDoesNotExist("מזהה לא קיים");
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {read}");
        return read;
       
       
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        if (filter != null)
        {
            return DataSource.Sales.Where(s => filter(s)).ToList();
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {(DataSource.Sales)}");
        return new List<Sale?>(DataSource.Sales);
    }
   public void Update(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Delete(item.SaleId);
        DataSource.Sales.Add (item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out");
    }
   public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        Sale item = Read(id);
        if (item != null) { 
            DataSource.Sales.Remove(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
               MethodBase.GetCurrentMethod().Name, $"went out");
        }
        else
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "Error! wrong Id");

            throw new DalIDoesNotExist("מזהה שגוי");

        }
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, "insert");
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name, $"went out and return {DataSource.Sales.Where(s => filter(s)).First()}");
        return DataSource.Sales.Where(s => filter(s)).First();
    }
}
