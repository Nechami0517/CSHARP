using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DalXml;

internal static class Config
{
    //static string relativePath = @"..\xml\data-config.xml"; // נתיב יחסי לתיקיית xml
    //static string absolutePath = Path.GetFullPath(relativePath); // המרת הנתיב היחסי לנתיב מוחלט
    //private static string nameXmlFile = @"..\xml\data-config.xml";
    //static XElement dataConfigXml = XElement.Load(absolutePath);
    //private const string FILE_PATH = "ConstProductId";
    private static string nameXmlFile = @"..\xml\data-config.xml";
    static XElement dataConfigXml = XElement.Load(nameXmlFile);
    private const string FILE_PATH = "ConstProductId";

    /// <summary>
    /// ערכי התחלה למזהים
    /// </summary>
    //a


    static XElement dataXml = XElement.Load(nameXmlFile);


    static int ConstProductId = int.Parse(dataXml.Element("ConstProductId").Value);
    static int ConstSaleId = int.Parse(dataXml.Element("ConstSaleId").Value);

    //b
    /// <summary>
    /// ערך המזהה הבא בתור
    /// </summary>
    private static int CodeProductId = ConstProductId;
    private static int CodeSaleId = ConstSaleId;
    //c
    /// <summary>
    /// קבלת מזהה נוכחי וקידומו
    /// </summary>
    public static int GetCodeProduct
    {
        get
        {
            dataXml.Element("ConstProductId").SetValue(CodeProductId + 1);
            dataXml.Save(FILE_PATH);
            return CodeProductId++;
        }

    }
    public static int GetCodeSale
    {
        get
        {
            dataXml.Element("ConstSaleId").SetValue(CodeSaleId + 1);
            dataXml.Save(FILE_PATH);
            return CodeSaleId++;
        }

    }
}
