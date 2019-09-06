
using DatShop.Data.Infrastructure;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IPageRepository
    {

    }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
