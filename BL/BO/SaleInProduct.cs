

namespace BO;

public class SaleInProduct
{
    private int? productId;
    private int? count;
    private bool? isClub;

    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int SaleCount { get; set; }
    public double Price { get; set; }
    public bool IsForAllCustomer { get; set; }
    public static object SaleList { get; internal set; }



    // בנאי מלא
    public SaleInProduct(int saleId, int productId, int saleCount, double price, bool isForAllCustomer)
    {
        this.SaleId = saleId;
        this.ProductId = productId;
        this.SaleCount = saleCount;
        this.Price = price;
        this.IsForAllCustomer = isForAllCustomer;
    }

    public SaleInProduct(int saleId, int? productId, int? count, double price, bool? isClub)
    {
        SaleId = saleId;
        this.productId = productId;
        this.count = count;
        Price = price;
        this.isClub = isClub;
    }

    public SaleInProduct()
    {
    }
}
