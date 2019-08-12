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
    class Tag
    {
        [Key]        
        string ID { set; get; }

        string Name { set; get; }

        string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

    }
}
