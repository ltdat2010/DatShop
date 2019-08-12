using System;

namespace DatShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
    }
}