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
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string CustomerName { set; get; }
        [StringLength(80)]
        public string CustomerAddress { set; get; }
        [StringLength(40)]
        public string CustomerEmail { set; get; }
        [StringLength(20)]
        public string CustomerMobile { set; get; }
        [StringLength(200)]
        public string CustomerMessage { set; get; }
        [StringLength(40)]
        public string PaymentMethod { set; get; }
        [StringLength(40)]
        public string PaymentStatus { set; get; }
        public IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
