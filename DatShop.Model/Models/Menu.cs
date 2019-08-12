using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("Menus")]
    class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string Name { set; get; }
        public string URL { set; get; }
        public int DisplayOrder { set; get; }
        public int Target { set; get; }
        public bool Status { set; get; }
        public int GroupID { set; get; }
        [ForeignKey("GroupID")]
        public virtual IEnumerable<MenuGroup> MenuGroups { set; get; }
    }
}
