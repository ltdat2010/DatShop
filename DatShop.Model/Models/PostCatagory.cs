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
    [Table("PostCatagories")]
    public class PostCatagory : InterFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(80)]
        public string Alias { set; get; }
        public int ParentID { set; get; }
        [StringLength(200)]
        public string Description { set; get; }
        public int DisplayOrder { set; get; }
        
        public string Image { set; get; }
        public XElement MoreImage { set; get; }
        public bool HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }

    }
}
