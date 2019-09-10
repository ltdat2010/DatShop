using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;
using System.Collections.Generic;

namespace DatShop.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _iProductRepository;
        private IUnitOfWork _iUnitOfWork;

        public ProductService(IProductRepository iProductRepsitory, IUnitOfWork iUnitOfWork)
        {
            this._iProductRepository = iProductRepsitory;
            this._iUnitOfWork = iUnitOfWork;
        }

        public void Add(Product product)
        {
            _iProductRepository.Add(product);
        }

        public void Delete(int id)
        {
            _iProductRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _iProductRepository.GetAll(new string[] { "ProductCatagory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _iProductRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _iProductRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Product GetById(int id)
        {
            return _iProductRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _iUnitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _iProductRepository.Update(product);
        }

        public void Update(Post post)
        {
            throw new System.NotImplementedException();
        }

        Post IProductService.GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}