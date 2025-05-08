using BlApi;
using BO;
using System.Linq;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public List<SaleInProduct> ActiveSales(int productId, bool isPrefer)
    {
        try
        {
            return _dal.Sale.ReadAll(s => s.ProductId == productId
                && s.IsClub == isPrefer && s.DateBeginSail > DateTime.Now)
                .Select(s => new SaleInProduct(s.SaleId, s.ProductId, s.Count, s.Price, s.IsClub)).ToList();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to retrieve active sales.", ex);
        }
    }

    public int Create(BO.Product product)
    {
        try
        {
            return _dal.Product.Create(product.Convert());
        }
        catch (DO.DalIdExist ex)
        {
            throw new BlIdExist("Product already exists.", ex);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Product does not exist.", ex);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public BO.Product? Read(int id)
    {
        try
        {
            return _dal.Product.Read(id).Convert();
        }
        catch (DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Product does not exist.", ex);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(p => filter(p.Convert())).Convert();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to read product based on filter.", ex);
        }
    }

    
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filters = null)
    {
        try
        {
            var products = _dal.Product.ReadAll();

            if (filters != null)
            {
                products = products.Where(product => filters(product.Convert())).ToList();
            }

            return products.Select(p => p.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to read all products.", ex);
        }
    }
    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert());
        }
        catch(DO.DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("ID does not exist", ex);
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to update product.", ex);
        }
    }
}
