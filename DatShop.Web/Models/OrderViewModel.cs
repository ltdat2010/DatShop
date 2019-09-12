using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Models
{
    public class OrderViewModel
    {
        public int ID { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomerMobile { set; get; }
        public string CustomerMessage { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public IEnumerable<OrderDetailViewModel> OrderDetailViewModels { set; get; }
    }
}