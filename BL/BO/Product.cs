

//using DO;

namespace BO;
/// <summary>
/// 
/// </summary>
/// <param name="ProductId">מזהה מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריות</param>
/// <param name="price">מחיר</param>
/// <param name="QuantityInStock">כמות במלאי</param>
public class Product
   
{
    public int ProductId { get; init; }
    public string? ProductName { get; set; }
    public DO.Categories? Category { get; set; }
    public double? price { get; set; }
    public int? QuantityInStock { get; set; }

    public override string ToString() => this.ToStringProperty();
   

    public Product(int ProductId, string? ProductName, DO.Categories? Category, double? price, int? QuantityInStock) 
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.Category = Category;
        this.price = price;
        this.QuantityInStock = QuantityInStock;
    }
}
