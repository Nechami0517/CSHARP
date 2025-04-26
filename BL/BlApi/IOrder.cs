

using BO;

namespace BlApi;

public interface IOrder
{
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int orderCount);
    void CalcTotalPriceForProduct(ProductInOrder product);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void deleteProductFromOrder(BO.Order order, int id);
   void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isPrefer);
   
}
