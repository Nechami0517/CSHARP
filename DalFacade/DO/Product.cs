


namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="ProductId">מזהה מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריות</param>
/// <param name="price">מחיר</param>
/// <param name="QuantityInStock">כמות במלאי</param>
public record Product
    (int ProductId,
    string? ProductName,
    Categories? Category,
    double? price,
    int? QuantityInStock)
{
    public Product() : this(0,"",Categories.bags,0,0)
    {

    }

    
}
