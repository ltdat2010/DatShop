using AutoMapper;
using DatShop.Model.Models;
using DatShop.Web.Models;

namespace DatShop.Web.Mapping
{
    public class AutoMappingConfiguration
    {
        //private static MapperConfigurationExpression _iMapperConfigurationExpression = null;

        public static void Configuration()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
            Mapper.CreateMap<PostCatagory, PostCatagoryViewModel>();
            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<OrderDetail, OrderDetailViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            Mapper.CreateMap<ProductCatagory, ProductCatagoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}