using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [StringLength(80)]
        public string Name { set; get; }
        [StringLength(80)]
        public string Skype { set; get; }
        [StringLength(20)]
        public string  Mobile { set; get; }
        [StringLength(80)]
        public string Email { set; get; }
        [StringLength(80)]
        public string Yahoo { set; get; }
        public bool Status { set; get; }
    }
}
