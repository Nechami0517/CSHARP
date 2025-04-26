
namespace BO;
/// <summary>
/// 
/// </summary>
/// <param name="CustomerId">מזהה לקוח</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="CustomerAdress">כתובת לקוח</param>
/// <param name="CustomerPhoneNumber">פלאפון לקוח</param>
public record Customer

{
    public  int  CustomerId { get; init; }
    public string? CustomerName { get; set; }
    public string? CustomerAdress { get; set; }
    public string? CustomerPhoneNumber { get; set; }
    public override string ToString() => this.ToStringProperty();





    public Customer(int CustomerId, string? CustomerName, string? CustomerAdress, string? CustomerPhoneNumber)
    {
        this.CustomerId = CustomerId;
        this.CustomerName = CustomerName;
        this.CustomerAdress = CustomerAdress;
        this.CustomerPhoneNumber = CustomerPhoneNumber;
    }
}
