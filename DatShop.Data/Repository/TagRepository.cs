using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
namespace DatShop.Data.Repository
{
    public interface ITagRepository : IRepository<Tag>
    {

    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
