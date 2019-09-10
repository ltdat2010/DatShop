using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatShop.UnitTest
{
    [TestClass]
    internal class PostCatagoryRepositoryTest
    {
        IDbFactory iDbFactory;
        IUnitOfWork iUnitOfWork;
        IPostCatagoryRepository iPostCatagoryRepository;

        [TestInitialize]
        public void Initialize()
        {
            iDbFactory = new DbFactory();
            iPostCatagoryRepository = new PostCatagoryRepository(iDbFactory);
            iUnitOfWork = new UnitOfWork(iDbFactory);

        }
        //[TestMethod]
        //public void PostCatagoryRepositoryGetAll()
        //{
        //    var list = iPostCatagoryRepository.GetAll().ToList();
        //    Assert.AreEqual(3, list.Count);
        //}

        [TestMethod]
        public void PostCatagoryRepositoryCreate()
        {
            PostCatagory postCatagory = new PostCatagory();
            postCatagory.Name = "Test-Catagory";
            postCatagory.Alias= "Test-Catagory";
            postCatagory.Status = true;
            var result = iPostCatagoryRepository.Add(postCatagory);
            iUnitOfWork.Commit();            
        }
    }
}