using Entprog.DataModel.Repository;
using Suppliers.DataModel;

namespace SuppliersINV.App.Models.Repositories
{
    public interface IProductRepo : IGenericRepo<Product>
    {
        //You can put specialized contracts
    }
}
