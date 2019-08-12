using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("Posts")]
    class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { set; get; }

        string Name { set; get; }

        string Alias { set; get; }

        int PostCatagoryID { set; get; }

        [ForeignKey("PostCatagoryID")]
        public virtual PostCatagory PostCatagory { set; get; } 


    }
}
