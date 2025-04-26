
using BO;
using DalApi;


namespace BlApi;

public interface IProduct
{

    List<BO.SaleInProduct> ActiveSales(int productId, bool isPrefer);
    int Create(Product product);
    Product? Read(int id);
    List<Product?> ReadAll(Func<Product, bool>? filters = null);
    void Update(Product item);
    void Delete(int id);
    Product? Read(Func<Product, bool> filter);


}
