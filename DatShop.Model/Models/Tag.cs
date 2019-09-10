using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(40)]
        public string Type { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

    }
}
