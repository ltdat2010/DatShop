using DatShop.Data.Infrastructure;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {


    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory DbFactory) : base(DbFactory)
        {

        }
    }
}
