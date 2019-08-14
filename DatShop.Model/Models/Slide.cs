using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(200)]
        public string Description { set; get; }
        public string Image { set; get; }
        [StringLength(80)]
        public string URL { set; get; }
        public int DisplayOrder { set; get; }
        public bool Status { set; get; }

    }
}
