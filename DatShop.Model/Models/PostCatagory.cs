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
    class PostCatagory : InterFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { set; get; }

        string Name { set; get; }

        string Alias { set; get; }

        int ParentID { set; get; }

        string Description { set; get; }

        int DisplayOrder { set; get; }

        string Image { set; get; }

        XElement MoreImage { set; get; }
        bool HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }

    }
}
