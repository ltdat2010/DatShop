using System;

namespace DatShop.Model.Abstract
{    public abstract class InterFields : IAuditable, ISeoable, ISwitchable
    {
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}