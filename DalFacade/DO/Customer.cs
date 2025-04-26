
namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="CustomerId">מזהה לקוח</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="CustomerAdress">כתובת לקוח</param>
/// <param name="CustomerPhoneNumber">פלאפון לקוח</param>
public record Customer
    (int CustomerId,string? CustomerName ,string? CustomerAdress, string? CustomerPhoneNumber)
{
    public Customer() : this(0,"","","")
    {

    }
}
