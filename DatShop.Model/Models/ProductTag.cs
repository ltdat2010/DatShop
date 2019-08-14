using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        public int ProductID { set; get; }

        [StringLength(80)]
        public string TagID { set; get; }

        [StringLength(80)]
        public string PostTags { set; get; }

        public int PostID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}