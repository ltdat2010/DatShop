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
    public  class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(80)]
        public string Alias { set; get; }
        public int PostCatagoryID { set; get; }
        [ForeignKey("PostCatagoryID")]
        public virtual PostCatagory PostCatagory { set; get; } 


    }
}
