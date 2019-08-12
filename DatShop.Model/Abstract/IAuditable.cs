using System;

namespace DatShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime UpdateDate { set; get; }
        string UpdateBy { set; get; }
    }
}