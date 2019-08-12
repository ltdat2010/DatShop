using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatShop.Model.Abstract;

namespace DatShop.Model.Models
{
    [Table("Pages")]
    class Page : Seoable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { set; get; }

        string Name { set; get; }

        string Content { set; get; }
    }
}
