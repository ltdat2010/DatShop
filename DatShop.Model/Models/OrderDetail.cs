using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("OrderDetails")]
    class OrderDetail
    {
        int OrderID { set; get; }

        int ProductID { set; get; }    
        
        decimal Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }


        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}
