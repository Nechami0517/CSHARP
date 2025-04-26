using BlApi;
using BO;
using DO;

namespace BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
            return _dal.Sale.Create(item.Convert());
        }
        catch(DalIdExist ex)
        {
            throw new BlIdExist("Sale already exists.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch (DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Sale does not exist.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).Convert();
        }
        catch (DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("Sale does not exist.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(s => filter(s.Convert())).Convert();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to read sale based on filter.", ex);
        }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            return _dal.Sale.ReadAll(sale => filter(sale.Convert()))
                .Select(s => s.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to read all sales.", ex);
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.Convert());
        }
        catch(DalIDoesNotExist ex)
        {
            throw new BlIDoesNotExist("ID does not exist.", ex);
        }
        catch (Exception ex)
        {
            throw new BlSystemException("Failed to update sale.", ex);
        }
    }
}
