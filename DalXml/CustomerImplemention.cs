using DalApi;
using DO;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Dal;

internal class CustomerImplemention : ICustomer
{
    private const string FILE_PATH = @"C:\Users\user1\Desktop\DalTest\xml\customers.xml";
   
    XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    public int Create(Customer newCustomer)
    {
        try
        {
            List<Customer> customers = new List<Customer>();
            
            if (File.Exists(FILE_PATH))
            {
                //קריאת הלקוחות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;
                }

                Customer c = customers.FirstOrDefault(c => c.CustomerId == newCustomer.CustomerId);
                //אם קיים כבר לקוח עם כזה id יחזיר שגיאה
                if (c != null)
                {
                    throw new DalIdExist("customer already exist");
                }
                //אחרת יוסיף את הלקוח וירשום ל-xml
                else
                {
                    customers.Add(newCustomer);
                    using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Write))
                    {
                        serializer.Serialize(fs, customers);
                    }
                    return newCustomer.CustomerId;
                }

            }
            return newCustomer.CustomerId;

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Create" + ex);
        }

    }

    public void Delete(int id)
    {
        try
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists(FILE_PATH))
            {
                //קריאת הלקוחות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;
                }

                Customer c = customers.FirstOrDefault(c => c.CustomerId == id);
                //אם קיים מוחק את הלקוח מהרשימה ומעדכן את ה-xml
                if (c != null)
                {
                    customers.Remove(c);
                    using (FileStream fs = new FileStream(FILE_PATH, FileMode.Create, FileAccess.Write))
                    {
                        serializer.Serialize(fs, customers);
                    }

                }


            }

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Delete" + ex);
        }
    }

    public Customer? Read(int id)
    {
        try
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists(FILE_PATH))
            {
                //קריאת הלקוחות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;
                }

                Customer c = customers.FirstOrDefault(c => c.CustomerId == id);
                //אם קיים מחזיר את הלקוח עם ה-id המבוקש 
                if (c == null)
                {
                    throw new Exception("id does not exist");
                }
                return c;
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Read" + ex);
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists(FILE_PATH))
            {
                //קריאת הלקוחות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;
                }

                Customer c = customers.FirstOrDefault(c => filter(c) != null);
                //אם קיים מחזיר את הלקוח עם ה-id המבוקש 
                if (c == null)
                {
                    throw new Exception("dont find");
                }
                return c;
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Read with filter" + ex);
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filters = null)
    {
        try
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists(FILE_PATH))
            {
                //קריאת הלקוחות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    customers = serializer.Deserialize(fs) as List<Customer>;
                }
                if (filters == null)
                    return customers;

                var q = from customer in customers
                         where filters(customer)
                         select customer;


                customers = q.ToList();


            }

            return customers;
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in ReadAll" + ex);
        }
    }


    public void Update(Customer item)
    {
        try
        {
            Delete(item.CustomerId);
            Create(item);
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Update" + ex);
        }
    }
}
