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

internal class SaleImplemention : ISale
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));

    private const string FILE_PATH = @"..\..\..\..\xml\sales.xml"; // נתיב יחסי לתיקיית xml
  static  string absolutePath = Path.GetFullPath(FILE_PATH); // המרת הנתיב היחסי לנתיב מוחלט
    // private const string FILE_PATH = @"C:\Users\user1\Desktop\DalTest\xml\sales.xml";
    XElement saleXml = XElement.Load(absolutePath);
    //public int Create(Sale item)
    //{
    //    try
    //    {
    //        if (File.Exists(FILE_PATH))
    //        {
    //            item = item with { SaleId = Config.GetCodeSale };
    //            saleXml.Add(new XElement("Sale",
    //                new XElement("SaleId", item.SaleId),
    //                new XElement("ProductId", item.ProductId),
    //                new XElement("Count", item.Count),
    //                new XElement("Price", item.Price),
    //                new XElement("IsClub", item.IsClub),
    //                new XElement("DateBeginSail", item.DateBeginSail),
    //                new XElement("DateEndSail", item.DateEndSail)
    //                ));
    //            saleXml.Save(FILE_PATH);

    //        }
    //        return item.SaleId;

    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException("this is Dal System Exception in Create" + ex);
    //    }
    //}

    public int Create(Sale newSale)
    {
        try
        {
            List<Sale> sales = new List<Sale>();

            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;
                }

                Sale c = sales.FirstOrDefault(c => c.SaleId == newSale.SaleId);
                //אם קיים כבר מוצר עם כזה id יחזיר שגיאה
                if (c != null)
                {
                    throw new DalIdExist("sale already exist");
                }
                //אחרת יוסיף את המוצר וירשום ל-xml
                else
                {
                    Sale s;
                    if (newSale.SaleId == 0)
                    {
                        s = newSale with { SaleId = Config.GetCodeSale };
                    }
                    else
                    {
                        s = newSale;
                    }

                    sales.Add(s);
                    using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Write))
                    {
                        serializer.Serialize(fs, sales);
                    }
                    return s.SaleId;
                }

            }
            return newSale.SaleId;

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Create" + ex);
        }

    }

    //public void Delete(int id)
    //{
    //    try
    //    {
    //        if (File.Exists(FILE_PATH))
    //        {
    //            if (Read(id) != null)
    //            {
    //                saleXml.Elements("Sale").Elements().FirstOrDefault(s => s.Element("SaleId").Value.Equals(id)).Remove();
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException("this is Dal System Exception in Delete" + ex);
    //    }
    //}


    public void Delete(int id)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            if (File.Exists(absolutePath))
            {
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;
                }

                Sale c = sales.FirstOrDefault(c => c.SaleId == id);
                if (c != null)
                {
                    sales.Remove(c);
                    using (FileStream fs = new FileStream(absolutePath, FileMode.Create, FileAccess.Write))
                    {
                        serializer.Serialize(fs, sales);
                    }
                }
            }

        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Delete" + ex);
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;
                }

                Sale c = sales.FirstOrDefault(c => c.SaleId == id);
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

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            if (File.Exists(absolutePath))
            {
                //קריאת הProductות הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;
                }

                Sale c = sales.FirstOrDefault(c => filter(c) == true);
                //אם קיים מחזיר את עם ה-id המבוקש 
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




    //public Sale? Read(int id)
    //{
    //    try
    //    {
    //        if (File.Exists(FILE_PATH))
    //        {

    //            XElement saleFound = saleXml.Elements("Sale").Elements().FirstOrDefault(s => s.Element("SaleId").Value.Equals(id));
    //            if (saleFound != null)
    //            {
    //                return new Sale((int)saleFound.Element("SaleId"),
    //                (int)saleFound.Element("ProductId"),
    //                (int)saleFound.Element("Count"),
    //                (int)saleFound.Element("Price"),
    //                (bool)saleFound.Element("IsClub"),
    //                (DateTime)saleFound.Element("DateBeginSail"),
    //                (DateTime)saleFound.Element("DateEndSail"));
    //            }
    //            throw new DO.DalIDoesNotExist("id not exist");
    //        }
    //        return null;
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException("this is Dal System Exception in Read" + ex);
    //    }
    //}

    //public Sale? Read(Func<Sale, bool> filter)
    //{

    //    try
    //    {
    //        if (File.Exists(FILE_PATH))
    //        {

    //            List<Sale> sales = saleXml.Elements("Sale").Elements().Select(s =>
    //                 new Sale((int)s.Element("SaleId"),
    //                 (int)s.Element("ProductId"),
    //                 (int)s.Element("Count"),
    //                 (int)s.Element("Price"),
    //                 (bool)s.Element("IsClub"),
    //                 (DateTime)s.Element("DateBeginSail"),
    //                 (DateTime)s.Element("DateEndSail"))).ToList();
    //            if (sales != null)
    //                return sales.FirstOrDefault(filter);



    //        }
    //        return null;
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException("this is Dal System Exception in Read with filter" + ex);
    //    }
    //}


    //public List<Sale> ReadAll(Func<Sale, bool>? filters = null)
    //{
    //    try
    //    {
    //        if (!File.Exists(FILE_PATH))
    //        {
    //            throw new DalSystemException($"File not found: {FILE_PATH}");
    //        }

    //        XElement saleXml = XElement.Load(FILE_PATH);

    //        List<Sale> sales = saleXml.Elements("Sale").Select(s =>
    //        {
    //            int saleId = (int?)s.Element("SaleId") ?? throw new DalSystemException("SaleId is missing or invalid");
    //            int? productId = (int?)s.Element("ProductId");
    //            int count = (int?)s.Element("Count") ?? 0;
    //            double price = (double?)s.Element("Price") ?? 0.0;
    //            bool? isClub = (bool?)s.Element("IsClub");
    //            DateTime? dateBeginSail = (DateTime?)s.Element("DateBeginSail");
    //            DateTime? dateEndSail = (DateTime?)s.Element("DateEndSail");

    //            return new Sale(saleId, productId, count, price, isClub, dateBeginSail, dateEndSail);
    //        }).ToList();

    //        //return filters != null ? sales.Where(filters).ToList() : sales;
    //        return filters != null ? sales.Where(s => s != null && filters(s)).ToList() : sales;

    //    }
    //    catch (FileNotFoundException ex)
    //    {
    //        throw new DalSystemException($"File not found: {FILE_PATH}  " + ex);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException($"Error in ReadAll: {ex.Message} " + ex);
    //    }
    //}

    public List<Sale?> ReadAll(Func<Sale, bool>? filters = null)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            if (File.Exists(absolutePath))
            {
                //קריאת המוצרים הקימים לתוך הרשימה 
                using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
                {
                    sales = serializer.Deserialize(fs) as List<Sale>;
                }
                if (filters == null)
                    return sales;

                var q = from Sale in sales
                        where filters(Sale)
                        select Sale;


                sales = q.ToList();


            }

            return sales;
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in ReadAll" + ex);
        }
    }

    //public List<Sale?> ReadAll(Func<Sale, bool>? filters = null)
    //{
    //    try
    //    {
    //        List<Sale> sales = new List<Sale>();
    //        if (File.Exists(absolutePath))
    //        {
    //            //קריאת המוצרים הקימים לתוך הרשימה 
    //            using (FileStream fs = new FileStream(absolutePath, FileMode.Open, FileAccess.Read))
    //            {
    //                sales = serializer.Deserialize(fs) as List<Sale>;
    //            }
    //            if (filters == null)
    //                return sales;

    //            var q = from Sale in sales
    //                    where filters(Sale)
    //                    select Sale;


    //            sales = q.ToList();


    //        }

    //        return sales;
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new DalSystemException("this is Dal System Exception in ReadAll" + ex);
    //    }
    //}

    public void Update(Sale item)
    {
        Delete(item.SaleId);
        Create(item);
    }
}
