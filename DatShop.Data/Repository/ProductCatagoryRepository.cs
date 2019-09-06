using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
namespace DatShop.Data.Repository
{
    public interface IProductCatagoryRepository:IRepository<ProductCatagory>
    {

    }
    public class ProductCatagoryRepository : RepositoryBase<ProductCatagory>, IProductCatagoryRepository
    {
        public ProductCatagoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
