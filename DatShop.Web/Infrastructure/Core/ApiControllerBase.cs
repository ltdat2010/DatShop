using DatShop.Model.Models;
using DatShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        IErrorService _iErrorService;

        public ApiControllerBase(IErrorService iErrorService)
        {

        }

        private void LogError (Exception ex)
        {
            Error _error = new Error();
            try
            {                
                _error.Message = ex.Message;
                _error.StackTrace = ex.StackTrace;
                _error.CreatedDate = DateTime.Now;
                _iErrorService.Create(_error);
                _iErrorService.Save();
            }

            catch
            {

            }

        }
    }
}