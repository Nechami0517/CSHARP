using DalApi;
//using DalApi;
using DO;
using Tools;

namespace DalTest;
internal class Program
{
    private static IDal s_dal = DalApi.Factory.Get;
    private static void Main(string[] args)
    {

        try
        {
            int initialize;
            Console.WriteLine("to initialize press 1 else 0");
            int.TryParse(Console.ReadLine(), out initialize);
                //initialize = 0;
            if (initialize == 1)
                Initialization.Initialize();

            int Mainchoose = ShowMainMenu();
            int? SubChoose = 0;
            while (Mainchoose != 0)
            {
                switch (Mainchoose)
                {

                    case 1:
                        SubChoose = SubMenu("Product");
                        AskProduct(SubChoose);
                        break;
                    case 2:
                        SubChoose = SubMenu("Sale");
                        AskSale(SubChoose);
                        break;
                    case 3:
                        SubChoose = SubMenu("Customer");
                        AskCustomer(SubChoose);
                        break;
                    case 4:
                        cleenLog();
                        break;
                    default:
                        ShowMainMenu();
                        break;

                }
                Mainchoose = ShowMainMenu();
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static int ShowMainMenu()
    {
        int choose;
        Console.WriteLine("for product press 1");
        Console.WriteLine("for sales press 2");
        Console.WriteLine("for customer press 3");
        Console.WriteLine("for clean log press 4");

        if (!int.TryParse(Console.ReadLine(), out choose))
            choose = -1;
        return choose;
    }
    private static int SubMenu(string? name)
    {
        int choose;
        Console.WriteLine($"to create {name} press 1");
        Console.WriteLine($"to read {name} press 2");
        Console.WriteLine($"to readAll {name} press 3");
        Console.WriteLine($"to update {name} press 4");
        Console.WriteLine($"to delete {name} press 5");
        Console.WriteLine("to exit press 0");
        if (!int.TryParse(Console.ReadLine(), out choose))
            choose = -1;

        return choose;
    }
    private static void AskProduct(int? choose)
    {

        switch (choose)
        {
            case 1:
                CreateProduct();
                break;
            case 2:
                ReadProduct();
                break;
            case 3:
                ReadAllProduct();
                break;
            case 4:
                UpdateProduct();
                break;
            case 5:
                DeleteProduct();
                break;

        }


    }
    private static void AskSale(int? choose)
    {

        switch (choose)
        {
            case 1:
                CreateSale();
                break;
            case 2:
                ReadSale();
                break;
            case 3:
                ReadAllSale();
                break;
            case 4:
                UpdateSale();
                break;
            case 5:
                DeleteSale();
                break;
        }


    }
    private static void AskCustomer(int? choose)
    {


        switch (choose)
        {
            case 1:
                CreateCustomer();
                break;
            case 2:
                ReadCustomer();
                break;
            case 3:
                ReadAllCustomer();
                break;
            case 4:
                UpdateCustomer();
                break;
            case 5:
                DeleteCustomer();
                break;
        }


    }
    private static int CreateProduct()
    {
        string? ProductName;
        int Category;
        double price;
        int QuantityInStock;
        Console.WriteLine("insert ProductName");
        ProductName = Console.ReadLine();
        Console.WriteLine("insert Category/n to  engraving prees 0 /nto wallets press 1/n to bags press 2/n to press 3/n to soaps press 4");
        if (!int.TryParse(Console.ReadLine(), out Category))
        {
            Category = 0;
        }
        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            price = 0;
        }
        Console.WriteLine("insert QuantityInStock");
        if (!int.TryParse(Console.ReadLine(), out QuantityInStock))
        {
            QuantityInStock = 0;
        }

        Product p = new Product(0, ProductName, (Categories)Category, price, QuantityInStock);
        return s_dal.Product.Create(p);

    }
    private static void ReadProduct()
    {
        int id;
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            id = 100;
        }

        Console.WriteLine(s_dal.Product.Read(id));

    }
    private static void ReadAllProduct()
    {
        List<Product> p = s_dal.Product.ReadAll();
        p.ForEach(p1 => Console.WriteLine(p1));
    }
    private static void UpdateProduct()
    {
        string? ProductName;
        int Category;
        double price;
        int QuantityInStock;
        Console.WriteLine("insert ProductName");
        ProductName = Console.ReadLine();
        Console.WriteLine("insert Category/n to  engraving prees 0 /nto wallets press 1/n to bags press 2/n to press 3/n to soaps press 4");
        if (!int.TryParse(Console.ReadLine(), out Category))
        {
            Category = 0;
        }
        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            price = 0;
        }
        Console.WriteLine("insert QuantityInStock");
        if (!int.TryParse(Console.ReadLine(), out QuantityInStock))
        {
            QuantityInStock = 0;
        }
        Product p = new Product(0, ProductName, (Categories)Category, price, QuantityInStock);
        s_dal.Product.Update(p);
    }
    private static void DeleteProduct()
    {
        int id;
        Console.WriteLine("insert productId to delete");
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            id = -1;
        }
        s_dal.Product.Delete(id);
    }

    private static int CreateSale()
    {
        int SaleId;
        int ProductId;     
        int Count;
        double Price;
        bool IsClub;
        int DateBeginSail;
        int DateEndSail;
        Console.WriteLine("insert ProductId");
        if (!int.TryParse(Console.ReadLine(), out ProductId))
        {
            throw new Exception("productId is not valid");
        }
        Console.WriteLine("insert count");
        if (!int.TryParse(Console.ReadLine(), out Count))
        {
            Count = 0;
        }
        Console.WriteLine("insert Price");
        if (!double.TryParse(Console.ReadLine(), out Price))
        {
            Price = 0;
        }
        Console.WriteLine("insert is for club");
        if (!bool.TryParse(Console.ReadLine(), out IsClub))
        {
            IsClub = true;
        }
        Console.WriteLine("insert num days that BeginSail from today");
        if (!int.TryParse(Console.ReadLine(), out DateBeginSail))
        {
            DateBeginSail = 0;
        }
        Console.WriteLine("insert num days that DateEndSail from today");
        if (!int.TryParse(Console.ReadLine(), out DateEndSail))
        {
            DateEndSail = 1;
        }

        Sale s = new Sale(0, ProductId, Count,Price, IsClub, DateTime.Today.AddDays(DateBeginSail), DateTime.Today.AddDays(DateEndSail));
        return s_dal.Sale.Create(s);

    }
    private static void ReadSale()
    {
        int id;
        Console.WriteLine("insert sale id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 1;

        Console.WriteLine(s_dal.Sale.Read(id));
    }

    private static void ReadAllSale()
    {
        List<Sale> p = s_dal.Sale.ReadAll();
        p.ForEach(x => Console.WriteLine(x));
    }

    private static void UpdateSale()
    {
        int SaleId;
        int ProductId;
        int Count;
        double Price;
        bool IsClub;
        int DateBeginSail;
        int DateEndSail;

        Console.WriteLine("insert ProductId");
        if (!int.TryParse(Console.ReadLine(), out ProductId))
        {
            throw new Exception("productId is not valid");
        }
        Console.WriteLine("insert count");
        if (!int.TryParse(Console.ReadLine(), out Count))
        {
            Count = 0;
        }
        Console.WriteLine("insert Price");
        if (!double.TryParse(Console.ReadLine(), out Price))
        {
            Price = 0;
        }
        Console.WriteLine("insert is for club");
        if (!bool.TryParse(Console.ReadLine(), out IsClub))
        {
            IsClub = true;
        }
        Console.WriteLine("insert num days that BeginSail from today");
        if (!int.TryParse(Console.ReadLine(), out DateBeginSail))
        {
            DateBeginSail = 0;
        }
        Console.WriteLine("insert num days that DateEndSail from today");
        if (!int.TryParse(Console.ReadLine(), out DateEndSail))
        {
            DateEndSail = 1;
        }


        Sale s = new Sale(0, ProductId, Count, Price, IsClub, DateTime.Today.AddDays(DateBeginSail), DateTime.Today.AddDays(DateEndSail));


        s_dal.Sale.Update(s);
    }

    private static void DeleteSale()
    {
        int id;
        Console.WriteLine("enter sale Id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = -1;
        s_dal.Sale.Delete(id);
    }

    private static int CreateCustomer()
    {
        int CustomerId;
        string CustomerName;
        string CustomerAdress;
        string CustomerPhoneNumber;
        Console.WriteLine("insert CustomerId");
        if (!int.TryParse(Console.ReadLine(), out CustomerId))
        {
            throw new Exception("CustomerId is not valid");
        }
        Console.WriteLine("insert CustomerName");
        CustomerName = Console.ReadLine();
        Console.WriteLine("insert CustomerAdress");

        CustomerAdress = Console.ReadLine();

        Console.WriteLine("insert CustomerPhoneNumber");

        CustomerPhoneNumber = Console.ReadLine();



        Customer c = new Customer(CustomerId, CustomerName, CustomerAdress, CustomerPhoneNumber);
        return s_dal.Customer.Create(c);

    }
    private static void ReadCustomer()
    {
        int id;
        Console.WriteLine("insert customer Id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 1;
        Console.WriteLine(s_dal.Customer.Read(id));
    }


    private static void ReadAllCustomer()
    {
        List<Customer> p = s_dal.Customer.ReadAll();
        p.ForEach(x => Console.WriteLine(x));
    }

    private static void UpdateCustomer()
    {
        int CustomerId;
        string CustomerName;
        string CustomerAdress;
        string CustomerPhoneNumber;
        Console.WriteLine("insert CustomerId");
        if (!int.TryParse(Console.ReadLine(), out CustomerId))
        {
            throw new Exception("CustomerId is not valid");
        }
        Console.WriteLine("insert CustomerName");
        CustomerName = Console.ReadLine();
        Console.WriteLine("insert CustomerAdress");

        CustomerAdress = Console.ReadLine();

        Console.WriteLine("insert CustomerPhoneNumber");

        CustomerPhoneNumber = Console.ReadLine();



        Customer c = new Customer(CustomerId, CustomerName, CustomerAdress, CustomerPhoneNumber);
        s_dal.Customer.Update(c);
    }
    private static void DeleteCustomer()
    {
        int id;
        Console.WriteLine("enter customer Id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = -1;
        s_dal.Customer.Delete(id);
    }
    private static void cleenLog()
    {
        LogManager.cleenLog();
    }
}