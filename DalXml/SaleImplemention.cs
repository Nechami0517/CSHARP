using DalApi;
using DalXml;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal;

internal class SaleImplemention : ISale
{
    private const string FILE_PATH = @"C:\Users\user1\Desktop\DalTest\xml\sales.xml";
    XElement saleXml = XElement.Load(FILE_PATH);
    public int Create(Sale item)
    {
        try
        {
            if (File.Exists(FILE_PATH))
            {
                item = item with { SaleId = Config.GetCodeSale };
                saleXml.Add(new XElement("Sale",
                    new XElement("SaleId", item.SaleId),
                    new XElement("ProductId", item.ProductId),
                    new XElement("Count", item.Count),
                    new XElement("Price", item.Price),
                    new XElement("IsClub", item.IsClub),
                    new XElement("DateBeginSail", item.DateBeginSail),
                    new XElement("DateEndSail", item.DateEndSail)
                    ));
                saleXml.Save(FILE_PATH);

            }
            return item.SaleId;

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
            if (File.Exists(FILE_PATH))
            {
                if (Read(id) != null)
                {
                    saleXml.Elements("Sale").Elements().FirstOrDefault(s => s.Element("SaleId").Value.Equals(id)).Remove();
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
            if (File.Exists(FILE_PATH))
            {

                XElement saleFound = saleXml.Elements("Sale").Elements().FirstOrDefault(s => s.Element("SaleId").Value.Equals(id));
                if (saleFound != null)
                {
                    return new Sale((int)saleFound.Element("saleId"),
                    (int)saleFound.Element("ProductId"),
                    (int)saleFound.Element("Count"),
                    (int)saleFound.Element("Price"),
                    (bool)saleFound.Element("IsClub"),
                    (DateTime)saleFound.Element("DateBeginSail"),
                    (DateTime)saleFound.Element("DateEndSail"));
                }
                throw new DO.DalIDoesNotExist("id not exist");
            }
            return null;
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
            if (File.Exists(FILE_PATH))
            {

                List<Sale> sales = saleXml.Elements("Sale").Elements().Select(s =>
                 new Sale((int)s.Element("saleId"),
                     (int)s.Element("ProductId"),
                     (int)s.Element("Count"),
                     (int)s.Element("Price"),
                     (bool)s.Element("IsClub"),
                     (DateTime)s.Element("DateBeginSail"),
                     (DateTime)s.Element("DateEndSail"))).ToList();
                if (sales != null)
                    return sales.FirstOrDefault(filter);



            }
            return null;
        }
        catch (Exception ex)
        {
            throw new DalSystemException("this is Dal System Exception in Read with filter" + ex);
        }
    }


    public List<Sale> ReadAll(Func<Sale, bool>? filters = null)
    {
        try
        {
            if (!File.Exists(FILE_PATH))
            {
                throw new DalSystemException($"File not found: {FILE_PATH}");
            }

            XElement saleXml = XElement.Load(FILE_PATH);

            List<Sale> sales = saleXml.Elements("Sale").Select(s =>
            {
                int saleId = (int?)s.Element("SaleId") ?? throw new DalSystemException("SaleId is missing or invalid");
                int? productId = (int?)s.Element("ProductId");
                int count = (int?)s.Element("Count") ?? 0;
                double price = (double?)s.Element("Price") ?? 0.0;
                bool? isClub = (bool?)s.Element("IsClub");
                DateTime? dateBeginSail = (DateTime?)s.Element("DateBeginSail");
                DateTime? dateEndSail = (DateTime?)s.Element("DateEndSail");

                return new Sale(saleId, productId, count, price, isClub, dateBeginSail, dateEndSail);
            }).ToList();

            return filters != null ? sales.Where(filters).ToList() : sales;
        }
        catch (FileNotFoundException ex)
        {
            throw new DalSystemException($"File not found: {FILE_PATH}  " +  ex);
        }
        catch (Exception ex)
        {
            throw new DalSystemException($"Error in ReadAll: {ex.Message} "+ ex);
        }
    }
    public void Update(Sale item)
    {
        Delete(item.SaleId);
        Create(item);
    }
}
