using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class PostTagViewModel
    {
        public int ID { set; get; }
        public int PostID { set; get; }
        public string TagID { set; get; }
    }
}