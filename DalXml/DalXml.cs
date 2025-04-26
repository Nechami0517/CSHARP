using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal;

internal sealed class DalXml : IDal
{
    public IProduct Product => new ProductImplemention();

    public ISale Sale => new SaleImplemention();

    public ICustomer Customer => new CustomerImplemention();
    private static readonly DalXml instance = new DalXml();
    private DalXml() { }
    public static DalXml Instance => instance;

}


