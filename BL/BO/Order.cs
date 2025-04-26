
namespace BO;
public class Order
{
    private int id;

    public Order(bool isPrefer)
    {
        this.IsPreferredCustomer = isPrefer;
        ProductList = new List<ProductInOrder>();
    }

    public bool IsPreferredCustomer { get; set; }
    public List<ProductInOrder> ProductList { get; set; }
    public double FinalPrice { get; set; }
    public override string ToString() => this.ToStringProperty();
}