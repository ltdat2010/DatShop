using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class OrderDetailViewModel
    {
        public int OrderID { set; get; }
        public int ProductID { set; get; }
        public decimal Quantity { set; get; }
        public virtual OrderViewModel OrderViewModels { set; get; }
        public virtual ProductViewModel ProductViewModels { set; get; }
    }
}