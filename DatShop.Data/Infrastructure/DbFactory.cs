namespace DatShop.Data.Infrastructure
{
    //https://stackoverflow.com/questions/10925257/best-repository-pattern-for-asp-net-mvc?noredirect=1&lq=1
    public class DbFactory : Disposable, IDbFactory
    {
        private DatShopDbContext DbContext;

        //public DatShopDbContext Get()
        //{
        //    return dataContext ?? (dataContext = new DatShopDbContext());
        //}

        public DatShopDbContext Init()
        {
            return DbContext ?? (DbContext = new DatShopDbContext());
        }

        protected void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }
    }
}