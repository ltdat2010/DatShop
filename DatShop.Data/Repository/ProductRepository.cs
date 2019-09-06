using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
namespace DatShop.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
