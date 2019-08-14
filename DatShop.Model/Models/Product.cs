using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatShop.Model.Abstract;


namespace DatShop.Model.Models
{
    [Table("Products")]
    public class Product : InterFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(80)]
        public string Alias { set; get; }
        public int ProductCatagoryID { set; get; }        
        [ForeignKey("ProductCatagoryID")]
        public virtual ProductCatagory ProductCatagory { set; get; }
        public string Image { set; get; }
        public XElement MoreImage { set; get; }
        [StringLength(200)]
        public string Description { set; get; }
        [StringLength(200)]
        public string Content { set; get; }        
        
        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        public int Warranty { set; get; }
        public int ViewCount { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }






    }
}
