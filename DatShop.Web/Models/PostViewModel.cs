using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }        
        public string Name { set; get; }        
        public string Alias { set; get; }
        public int PostCatagoryID { set; get; }
        public virtual PostCatagoryViewModel PostCatagoryViewModel { set; get; }
        public virtual IEnumerable<TagViewModel> TagViewModels { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}