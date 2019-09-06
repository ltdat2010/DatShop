using DatShop.Data.Infrastructure;
using DatShop.Model.Models;
namespace DatShop.Data.Repository
{
    public interface IPostCatagoryRepository: IRepository<PostCatagory>
    {

    }
    public class PostCatagoryRepository : RepositoryBase<PostCatagory>, IPostCatagoryRepository
    {
        public PostCatagoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
