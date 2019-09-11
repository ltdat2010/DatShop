using DatShop.Model.Models;
using DatShop.Service;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _iErrorService;
        public ApiControllerBase()
        {

        }

        public ApiControllerBase(IErrorService iErrorService)
        {
            _iErrorService = iErrorService;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage httpRequestMessage, Func<HttpResponseMessage> func) 
        {
            HttpResponseMessage httpResponseMessage = null;
            try
            {
                httpResponseMessage = func.Invoke();
            }
            catch (DbUpdateException dbEX)
            {
                LogError(dbEX);
                httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEX.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest,ex.Message);
            }
            return httpResponseMessage;
        }

        private void LogError(Exception ex)
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