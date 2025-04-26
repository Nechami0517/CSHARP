using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    

    public static void Initialize()
    {
        //s_dal = dal;
        s_dal = DalApi.Factory.Get;
        CreateCustomers();  
        CreateProducts();
        CreateSales();
    }
    /// <summary>
    /// יצירת מוצרים חדשים
    /// </summary>
    private static void CreateProducts()
    {
        s_dal.Product.Create(new Product(0, "pen", Categories.engraving, 50, 150));
        s_dal.Product.Create(new Product(0, "soup", Categories.soaps, 20, 100));
        s_dal.Product.Create(new Product(0, "bag", Categories.bags, 200, 250));
        s_dal.Product.Create(new Product(0, "braclate", Categories.jewelry, 100, 50));
        s_dal.Product.Create(new Product(0, "menWallets", Categories.wallets, 300, 25));
    }
    /// <summary>
    /// יצירת מבצעים חדשים
    /// </summary>
    private static void CreateSales()
    {
        s_dal.Sale.Create(new Sale(0, 100,2, 70, false, DateTime.Now, DateTime.MaxValue));
        s_dal.Sale.Create(new Sale(0, 101,2, 15, true, DateTime.Now, DateTime.MaxValue));
    }
    /// <summary>
    /// יצירת לוקחות חדשים
    /// </summary>
    private static void CreateCustomers()
    {
        s_dal.Customer.Create(new Customer(215310517, "Nechami Shwartz", "הרב מפונוביז' 8", "0583212449"));
        s_dal.Customer.Create(new Customer(327867792, "Michal Busgrian", "רבי עקיבא 9", "0527652458"));
    }
}
