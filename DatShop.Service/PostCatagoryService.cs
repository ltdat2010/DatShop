using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;
using System.Collections.Generic;

namespace DatShop.Service
{
    public interface IPostCatagoryService
    {
        PostCatagory Add(PostCatagory postCatagory);

        void Update(PostCatagory postCatagory);

        void Delete(int id);

        IEnumerable<PostCatagory> GetAll();

        IEnumerable<PostCatagory> GetAllByParentId(int parentId);

        PostCatagory GetById(int Id);

        void SaveChange();

    }

    public class PostCatagoryService : IPostCatagoryService
    {
        private IPostCatagoryRepository _iPostCatagoryRepository;
        private UnitOfWork _iUnitOfWork;

        public PostCatagoryService(IPostCatagoryRepository iPostCatagoryRepository, UnitOfWork  iUnitOfWork)
        {
            this._iPostCatagoryRepository = iPostCatagoryRepository;
            this._iUnitOfWork = iUnitOfWork;
        }

        public PostCatagory Add(PostCatagory postCatagory)
        {
            return _iPostCatagoryRepository.Add(postCatagory);
        }

        public void Delete(int id)
        {
            _iPostCatagoryRepository.Delete(id);
        }

        public IEnumerable<PostCatagory> GetAll()
        {
            return _iPostCatagoryRepository.GetAll();
        }

        public IEnumerable<PostCatagory> GetAllByParentId(int parentId)
        {
            return _iPostCatagoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCatagory GetById(int Id)
        {
            return _iPostCatagoryRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _iUnitOfWork.Commit();
        }

        public void Update(PostCatagory postCatagory)
        {
            _iPostCatagoryRepository.Update(postCatagory);
        }
    }
}