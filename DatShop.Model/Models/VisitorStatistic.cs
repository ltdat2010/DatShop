using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        public int ID { set; get; }

        public DateTime VisitDate { set; get; }

        public string IPAddress { set; get; }
    }
}
