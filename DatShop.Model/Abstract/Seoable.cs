using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Abstract
{
    public abstract class Seoable : ISeoable
    {
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
