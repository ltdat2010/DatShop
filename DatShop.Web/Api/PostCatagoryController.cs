using AutoMapper;
using DatShop.Model.Models;
using DatShop.Service;
using DatShop.Web.Infrastructure.Core;
using DatShop.Web.Infrastructure.Extensions;
using DatShop.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatShop.Web.Api
{
    [RoutePrefix("Api/PostCatagory")]
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
        [Route("Add")]
        public HttpResponseMessage Post(HttpRequestMessage httpRequestMessage, PostCatagoryViewModel postCatagoryViewModel)
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
                    PostCatagory _postCatagory = new PostCatagory();
                    _postCatagory.UpdatePostCatagory(postCatagoryViewModel);
                    var postCata = _iPostCatagoryService.Add(_postCatagory);
                    _iPostCatagoryService.SaveChange();

                    _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK, postCata);
                }
                return _httpResponseMessage;
            }
             );
        }

        //Update
        [Route("Update")]
        public HttpResponseMessage Put(HttpRequestMessage httpRequestMessage, PostCatagoryViewModel postCatagoryViewModel)
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
                    var postCatagoryDb = _iPostCatagoryService.GetById(postCatagoryViewModel.ID);
                    postCatagoryDb.UpdatePostCatagory(postCatagoryViewModel);
                    _iPostCatagoryService.Update(postCatagoryDb);
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
        public HttpResponseMessage Get(HttpRequestMessage httpRequestMessage)
        {
            return CreateHttpResponse(httpRequestMessage, () =>
            {
                var listPostCatagory = _iPostCatagoryService.GetAll();

                var listPostCatagoryViewModel = Mapper.Map<List<PostCatagoryViewModel>>(listPostCatagory);

                _iPostCatagoryService.SaveChange();

                HttpResponseMessage _httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK, listPostCatagory);

                return _httpResponseMessage;
            });
        }
    }
}