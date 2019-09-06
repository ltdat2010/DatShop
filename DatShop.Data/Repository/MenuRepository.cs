using DatShop.Data.Infrastructure;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    public class MenuRepository: RepositoryBase<Menu> , IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
