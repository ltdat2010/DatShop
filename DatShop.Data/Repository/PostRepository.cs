using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
namespace DatShop.Data.Repository
{
    public interface IPostRepository
    {

    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
