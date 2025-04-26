

namespace BO;

public class ProductInOrder
{
    

   

    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double BasePrice { get; set; }
    public int ProductCount { get; set; }
    public List<SaleInProduct>? SaleList { get; set; }
    public double FinalPrice { get; set; }

    public override string ToString() => this.ToStringProperty();
    public ProductInOrder(int productId, string productName, double basePrice, int productCount, List<SaleInProduct>? saleList = null)
    {
        ProductId = productId;
        ProductName = productName;
        BasePrice = basePrice;
        ProductCount = productCount;
        SaleList = saleList ?? new List<SaleInProduct>(); // אם saleList הוא null, אתחל לרשימה ריקה
        FinalPrice = 0; // חישוב מחיר סופי (אם יש צורך)
    }
}
