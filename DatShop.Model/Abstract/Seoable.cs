namespace DatShop.Model.Abstract
{
    public abstract class Seoable : ISeoable
    {
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}