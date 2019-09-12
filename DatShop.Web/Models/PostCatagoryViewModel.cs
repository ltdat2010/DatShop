using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class PostCatagoryViewModel
    {
        public int ID { set; get; }        
        public string Name { set; get; }        
        public string Alias { set; get; }
        public int ParentID { set; get; }        
        public string Description { set; get; }
        public int DisplayOrder { set; get; }
        public string Image { set; get; }
        //public XElement MoreImage { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<PostViewModel> PostViewModels { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}