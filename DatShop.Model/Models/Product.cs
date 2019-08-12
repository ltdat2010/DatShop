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
    class Product : InterFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { set; get; }

        string Name { set; get; }

        string Alias { set; get; }

        int ProductCatagoryID { set; get; }
        
        [ForeignKey("ProductCatagoryID")]
        public virtual ProductCatagory ProductCatagory { set; get; } 

        string Image { set; get; }

        XElement MoreImage { set; get; }

        string Description { set; get; }

        string Content { set; get; }
        
        decimal Price { set; get; }

        decimal PromotionPrice { set; get; }

        int Warranty { set; get; }

        int ViewCount { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }






    }
}
