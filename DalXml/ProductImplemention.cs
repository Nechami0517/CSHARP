using DalApi;
using DalXml;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplemention : IProduct
{
    /*   private const string FILE_PATH = @"../xml\products.xml"; // נתיב יחסי לתיקיית xml
        string absolutePath = Path.GetFullPath(FILE_PATH); // המרת הנתיב היחסי לנתיב מוחלט*/

    string absolutePath = @"C:\Users\user1\Desktop\DalTest\xml\products.xml";

    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    public int Create(Product newProduct)
    {
        try
        {
            List<Product> products = new List<Product>();
           
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(fs) as List<Product>;
                }

                Product c = products.FirstOrDefault(c => c.ProductId == newProduct.ProductId);
                //אם קיים כבר מוצר עם כזה id יחזיר שגיאה
                if (c != null)
                {
                    throw new DalIdExist("product already exist");
                }
                //אחרת יוסיף את המוצר וירשום ל-xml
                else
                {
                    Product p = newProduct with { ProductId = Config.GetCodeProduct };
                    products.Add(p);
                    using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Write))
                    {
                        serializer.Serialize(fs, products);
                    }
                    return p.ProductId;
                }

            }
            return newProduct.ProductId;

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
            List<Product> products = new List<Product>();
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(fs) as List<Product>;
                }

                Product c = products.FirstOrDefault(c => c.ProductId == id);
                //אם קיים מוחק את המוצר מהרשימה ומעדכן את ה-xml
                if (c != null)
                {
                    products.Remove(c);
                    using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Write))
                    {
                        serializer.Serialize(fs, products);
                    }

                }


            }

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Delete" + ex);
        }
    }

    public Product? Read(int id)
    {
        try
        {
            List<Product> products = new List<Product>();
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(fs) as List<Product>;
                }

                Product c = products.FirstOrDefault(c => c.ProductId == id);
                //אם קיים מחזיר את המוצר עם ה-id המבוקש 
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

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            List<Product> products = new List<Product>();
            if (File.Exists(absolutePath))
            {
                //קריאת הProductות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(fs) as List<Product>;
                }

                Product c = products.FirstOrDefault(c => filter(c) == true);
                //אם קיים מחזיר את הProduct עם ה-id המבוקש 
                if (c == null)
                {
                    throw new DalIDoesNotExist("dont find");
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

    public List<Product?> ReadAll(Func<Product, bool>? filters = null)
    {
        try
        {
            List<Product> products = new List<Product>();
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(fs) as List<Product>;
                }
                if (filters == null)
                    return products;

                var q = from Product in products
                        where filters(Product)
                        select Product;


                products = q.ToList();


            }

            return products;
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in ReadAll" + ex);
        }
    }


    public void Update(Product item)
    {
        try
        {
            Delete(item.ProductId);
            Create(item);
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Update" + ex);
        }
    }
}
