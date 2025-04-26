
using BlApi;
using BO;
using DO;
using System.Collections.Generic;

namespace BlImplementation;

class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    // מתודה להוספת מוצר להזמנה – מקבלת כפרמטרים הזמנה
    // (BO.Order), מזהה מוצר (int) וכמות להזמנה (int). מחזירה רשימת מבצעים
    // שהתקבלו למוצר שנוסף (רשימה מסוג BO.SaleInProduct).


    public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isPrefer)
    {
        try
        {
            productInOrder.SaleList = _dal.Sale.ReadAll(s => (s.ProductId == productInOrder.ProductId
            && (!(s.IsClub ?? false) || isPrefer)
            && DateTime.Now >= s.DateBeginSail
            && DateTime.Now <= s.DateEndSail
            && s.Count <= productInOrder.ProductCount))
            .Select(s => new BO.SaleInProduct()
            {
                SaleId = s.SaleId,
                ProductId = productInOrder.ProductId,
                SaleCount = s.Count,
                Price = s.Price,
                IsForAllCustomer = isPrefer,

            }).ToList();
        }

        catch (Exception ex)
        {
            throw new Exception($"Error in SearchSaleForProduct: {ex.Message}", ex);
        }

    }
    // מתודה לחישוב המחיר הסופי למוצר – מקבלת כפרמטר מוצר מסוג
    // BO.ProductInOrder
    // ולא מחזירה ערך.
    public void CalcTotalPriceForProduct(ProductInOrder product)
    {
        try
        {
            if (product.SaleList == null)
            {
                product.FinalPrice = product.BasePrice * product.ProductCount;
            }
            else
            {
                product.FinalPrice = 0;
                int count = product.ProductCount;
                List<BO.SaleInProduct> sales = new List<BO.SaleInProduct>();
                foreach (BO.SaleInProduct sale in product.SaleList)
                {
                    if (sale.SaleCount <= count)
                    {
                        int amount = count / sale.SaleCount;
                        product.FinalPrice += amount * sale.Price;
                        count = count % sale.SaleCount;
                        sales.Add(sale);
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
                if (count > 0)
                {
                    product.FinalPrice += product.BasePrice * count;
                }
/*                product.SaleList = sales;
*/            }
        }
        catch
        {
            throw new Exception();
        }
    }


    // מתודה לחישוב המחיר הסופי להזמנה – מקבלת כפרמטר הזמנה (BO.Order) ולא מחזירה ערך
    public void CalcTotalPrice(Order order)
    {
        //foreach (BO.ProductInOrder product in order.ProductList)
        //{
        //    order.FinalPrice += product.FinalPrice;
        //}

        order.FinalPrice = order.ProductList.Sum(o => o.FinalPrice);
    }


    // מתודה להוספת מוצר להזמנה – מקבלת כפרמטרים הזמנה
    // (BO.Order), מזהה מוצר (int) וכמות להזמנה (int). מחזירה רשימת מבצעים שהתקבלו למוצר שנוסף
    // (רשימה מסוג BO.SaleInProduct).

    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int countToAdd)
    {
        try
        {
            DO.Product myProduct = _dal.Product.Read(id);
            //בדיקה האם המוצר קיים כבר בהזמנה
            BO.ProductInOrder currentProduct = order.ProductList.FirstOrDefault(p => p.ProductId == id);
            if (currentProduct != null)
            {
                if (myProduct.QuantityInStock >= currentProduct.ProductCount + countToAdd)
                {
                    currentProduct.ProductCount += countToAdd;
                    
                }
                else
                    if (currentProduct.ProductCount > 0 && currentProduct.ProductCount < countToAdd)
                    {
                            currentProduct.ProductCount += (int)myProduct.QuantityInStock;
                }
                else
                    throw new Exception();
            }
            else
            {
                if (myProduct.QuantityInStock >= countToAdd)
                {

                    currentProduct = new ProductInOrder(myProduct.ProductId, myProduct.ProductName, (double)myProduct.price, countToAdd, null);
                    order.ProductList.Add(currentProduct);
                }
                else
                    throw new Exception();
            }
            SearchSaleForProduct(currentProduct, order.IsPreferredCustomer);
            CalcTotalPriceForProduct(currentProduct);
            CalcTotalPrice(order);
            return currentProduct.SaleList;

        }
        catch
        {
            throw new Exception();
        }
    }
    public void deleteProductFromOrder(Order order,int id)
    {
        order.ProductList = order.ProductList.Where(p => p.ProductId != id).ToList();
        CalcTotalPrice(order);
    }
    public void DoOrder(Order order)
    {
        foreach (BO.ProductInOrder p in order.ProductList)
        {
            DO.Product p1 = _dal.Product.Read(p.ProductId);
            _dal.Product.Update(p1 with { QuantityInStock = p1.QuantityInStock - p.ProductCount });
        }
    }


}