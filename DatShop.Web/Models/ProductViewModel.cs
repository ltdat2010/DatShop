using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }        
        public string Name { set; get; }       
        public string Alias { set; get; }
        public int ProductCatagoryID { set; get; }        
        public virtual ProductCatagoryViewModel ProductCatagoryViewModel { set; get; }
        public string Image { set; get; }        
        //public XElement MoreImage { set; get; }        
        public string Description { set; get; }        
        public string Content { set; get; }
        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        public int Warranty { set; get; }
        public int ViewCount { set; get; }
        public virtual IEnumerable<ProductTagViewModel> ProductTagViewModels { set; get; }
        public virtual IEnumerable<OrderDetailViewModel> OrderDetailViewModels { set; get; }
    }
}