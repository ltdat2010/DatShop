using System;
using System.Collections.Generic;
using System.Linq;
using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;


namespace DatShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();

    }
    public class PostService : IPostService
    {
        IPostRepository _iPostRepository;
        IUnitOfWork _iUnitOfWork;

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

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _iPostRepository.GetMultiPaging(x=>x.Status ,out totalRow ,page, pageSize );
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }      

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
