using DatShop.Data.Infrastructure;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {

    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
