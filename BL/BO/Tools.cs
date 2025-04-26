

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace BO;

internal static class Tools
{
    public static string ToStringProperty<T>(this T obj)
    {
        
        StringBuilder sb = new StringBuilder();
        Type t = obj?.GetType() ?? throw new Exception("Obj is NULL");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            sb.AppendLine($"{prop.Name} = {prop.GetValue(obj)}");
        }
        return sb.ToString();
    }

    public static BO.Product Convert(this DO.Product product)
    {
       return new BO.Product(product.ProductId, product.ProductName,product.Category,product.price,product.QuantityInStock);
    }

    public static DO.Product Convert(this BO.Product product)
    {
        return new DO.Product(product.ProductId, product.ProductName, product.Category, product.price, product.QuantityInStock);
    }

    public static BO.Customer Convert(this DO.Customer customer)
    {
        return new BO.Customer(customer.CustomerId,customer.CustomerName,customer.CustomerAdress,customer.CustomerPhoneNumber);
    }

    public static DO.Customer Convert(this BO.Customer customer)
    {
        return new DO.Customer(customer.CustomerId, customer.CustomerName, customer.CustomerAdress, customer.CustomerPhoneNumber);
    }

    public static BO.Sale Convert(this DO.Sale sale)
    {
        return new BO.Sale(sale.SaleId, sale.ProductId, sale.Count,sale.Price, sale.IsClub, sale.DateBeginSail, sale.DateEndSail);
    }

    public static DO.Sale Convert(this BO.Sale sale)
    {
        return new DO.Sale(sale.SaleId, sale.ProductId, sale.Count, sale.PriceInSale, sale.IsClub, sale.DateBeginSail, sale.DateEndSail);
    }

    //public static BO.ProductInOrder Convert(this DO.Product product)
    //{
    //    return new() { ProductId = product.ProductId, BasePrice = product.productPrice, ProductName = product.ProductName, FinalPrice = product.QuantityInStock };
    //}
}
