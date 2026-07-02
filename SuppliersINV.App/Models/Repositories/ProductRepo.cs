using Entprog.DataModel.Repository;
using Suppliers.DataModel;

namespace SuppliersINV.App.Models.Repositories
{
    public class ProductRepo : GenericRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext context) : base(context)
        {
        }
    }
}
