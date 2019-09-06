using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {

    }

    public class OrderRepository : RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}