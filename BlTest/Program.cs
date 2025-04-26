

using BlApi;
using BO;

//namespace BlTest;

internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.GetBl();
    static void Main(string[] args)
    {
        DalTest.Initialization.Initialize();
        // קליטת לקוח
        int id;
        Console.WriteLine("Please enter an customer ID or 0");
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            id = 0;
        }
        if (id != 0)
        {
            Customer currentCustomer = s_bl.Customer.Read(id);

        }



        bool doOrder = true;
        while (doOrder)
        {
            Order(id);
            Console.WriteLine("to add new order press true, to finish press false");
            while (!bool.TryParse(Console.ReadLine(), out doOrder))
            {
                Console.WriteLine("Invalid input. Please enter a valid bool.");
            }

        }

    }

    public static void Order(int customerId)
    {

        //יצירת הזמנה חדשה
        Order newOrder = new Order(customerId == 0 ? false : true);


        bool want = true;
        int productId;
        int capacity;
        while (want)
        {
            Console.WriteLine("insert productId");

            if (!int.TryParse(Console.ReadLine(), out productId))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                productId = 0;
            }
            Console.WriteLine("insert capacity");
            if (!int.TryParse(Console.ReadLine(), out capacity))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                capacity = 1;
            }

            s_bl.Order.AddProductToOrder(newOrder, productId, capacity);
            ProductInOrder product = newOrder.ProductList.FirstOrDefault(p => p.ProductId == productId);
            if (product.SaleList == null)
            {
                Console.WriteLine("there is no sales");
            }
            else
            {
                Console.WriteLine($"{product.ProductName} :");
                Console.WriteLine(product);
                foreach (var item in product.SaleList)
                {
                    Console.WriteLine($"{ item.SaleCount } in {item.Price}");
                }
            }

            Console.WriteLine($"finalPrice: {product.FinalPrice}");



            Console.WriteLine("to continue press true to finish press false");
            if (!bool.TryParse(Console.ReadLine(), out want))
            {
                want = false;
            }



        }
        //ביצוע ההזמנה בפועל
        Console.WriteLine($"FinalPrice to order: {newOrder.FinalPrice}");
        s_bl.Order.DoOrder(newOrder);
        
    }
}
