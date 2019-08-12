using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatShop.Model.Abstract;

namespace DatShop.Model.Models
{
    [Table("Orders")]
    class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { set; get; }

        string CustomerName { set; get; }
        string CustomerAddress { set; get; }
        string CustomerEmail { set; get; }
        string CustomerMobile { set; get; }
        string CustomerMessage { set; get; }
        string PaymentMethod { set; get; }
        string PaymentStatus { set; get; }


        public IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
