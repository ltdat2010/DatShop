using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatShop.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order=1)]
        public int ID { set; get; }

        public string Message { set; get; }
        public string StackTrace { set; get; }

        public DateTime CreatedDate { set; get; }
    }
}
