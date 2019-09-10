using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;
using System.Collections.Generic;

namespace DatShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCatagoryPaging(int catagoryId, int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        private IPostRepository _iPostRepository;
        private IUnitOfWork _iUnitOfWork;

        public PostService(IPostRepository iPostRepsitory, IUnitOfWork iUnitOfWork)
        {
            this._iPostRepository = iPostRepsitory;
            this._iUnitOfWork = iUnitOfWork;
        }

        public void Add(Post post)
        {
            _iPostRepository.Add(post);
        }

        public void Delete(int id)
        {
            _iPostRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _iPostRepository.GetAll(new string[] { "PostCatagory" });
        }

        public IEnumerable<Post> GetAllByCatagoryPaging(int catagoryId, int page, int pageSize, out int totalRow)
        {
            return _iPostRepository.GetMultiPaging(x => x.Status && x.PostCatagoryID == catagoryId, out totalRow, page, pageSize, new string[] { "PostCatagory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _iPostRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _iPostRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _iPostRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _iUnitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _iPostRepository.Update(post);
        }
    }
}