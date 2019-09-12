using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class ProductTagViewModel
    {
        public int ProductTagID { set; get; }        
        public int ProductID { set; get; }        
        public string TagID { set; get; }        
        public string PostTags { set; get; }
        public int PostID { set; get; }        
        public virtual ProductViewModel ProductViewModel { set; get; }        
        public virtual TagViewModel TagViewModel { set; get; }
    }
}