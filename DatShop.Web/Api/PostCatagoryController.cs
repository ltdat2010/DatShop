using DatShop.Model.Models;
using DatShop.Service;
using DatShop.Web.Infrastructure.Core;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatShop.Web.Api
{
    [RoutePrefix("api/postcatafory")]
    public class PostCatagoryController : ApiControllerBase
    {
        private IPostCatagoryService _iPostCatagoryService;

        public PostCatagoryController(
            IErrorService iErrorService,
            IPostCatagoryService iPostCatagoryService
            ) : base(iErrorService)
        {
            _iPostCatagoryService = iPostCatagoryService;
        }

        //Create
        public HttpResponseMessage Post(HttpRequestMessage httpRequestMessage, PostCatagory postCatagory)
        {
            return CreateHttpResponse(httpRequestMessage, () =>
            {
                HttpResponseMessage _httpResponseMessage = null;
                if (ModelState.IsValid)
                {
                    httpRequestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCata = _iPostCatagoryService.Add(postCatagory);
                    _iPostCatagoryService.SaveChange();

                    _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK, postCata);
                }
                return _httpResponseMessage;
            }
             );
        }

        //Update
        public HttpResponseMessage Put(HttpRequestMessage httpRequestMessage, PostCatagory postCatagory)
        {
            return CreateHttpResponse(httpRequestMessage, () =>
            {
                HttpResponseMessage _httpResponseMessage = null;
                if (ModelState.IsValid)
                {
                    httpRequestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _iPostCatagoryService.Update(postCatagory);
                    _iPostCatagoryService.SaveChange();

                    _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return _httpResponseMessage;
            }
             );
        }

        //Delete
        public HttpResponseMessage Delete(HttpRequestMessage httpRequestMessage, int id)
        {
            return CreateHttpResponse(httpRequestMessage, () =>
            {
                HttpResponseMessage _httpResponseMessage = null;
                if (ModelState.IsValid)
                {
                    httpRequestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _iPostCatagoryService.Delete(id);
                    _iPostCatagoryService.SaveChange();

                    _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return _httpResponseMessage;
            }
             );
        }

        //Select
        [Route("GetAll")]
        public HttpResponseMessage Get(HttpRequestMessage httpRequestMessage, int id)
        {
            return CreateHttpResponse(httpRequestMessage, () =>
            {
                HttpResponseMessage _httpResponseMessage = null;
                if (ModelState.IsValid)
                {
                    httpRequestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listPostCata = _iPostCatagoryService.GetAll();
                    _iPostCatagoryService.SaveChange();

                    _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK, listPostCata);
                }
                return _httpResponseMessage;
            }
             );
        }
    }
}