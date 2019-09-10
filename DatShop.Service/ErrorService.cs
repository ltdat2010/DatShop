using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Model.Models;
using System.Collections.Generic;

namespace DatShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
        
        void Save();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRepository _iErrorRepository;
        private IUnitOfWork _iUnitOfWork;

        public ErrorService(IErrorRepository iErrorRepsitory, IUnitOfWork iUnitOfWork)
        {
            this._iErrorRepository = iErrorRepsitory;
            this._iUnitOfWork = iUnitOfWork;
        }                

        public Error Create(Error error)
        {
            return _iErrorRepository.Add(error);
        }

        public void Save()
        {
            _iUnitOfWork.Commit();
        }

    }
}