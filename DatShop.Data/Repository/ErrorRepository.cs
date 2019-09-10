using DatShop.Data.Infrastructure;
using DatShop.Model.Models;

namespace DatShop.Data.Repository
{
    public interface IErrorRepository:IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}