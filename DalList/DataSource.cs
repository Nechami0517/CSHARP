
using DO;


namespace Dal;

internal static class DataSource
{
    
    internal  static List<Product?> products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();
    internal static List<Customer?> customers = new List<Customer?>();    
    
     internal static class Config
    {   //a
        /// <summary>
        /// ערכי התחלה למזהים
        /// </summary>
        internal const int  ConstProductId = 100;
        internal const int ConstSaleId = 1000;
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
            get { return CodeProductId++; }
           
        }
        public static int GetCodeSale
        {
            get { return CodeSaleId++; }

        }




    }
    }


