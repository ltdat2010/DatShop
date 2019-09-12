using DatShop.Model.Models;
using DatShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePost(this Post post , PostViewModel postViewModel)
        {
            //public int ID { set; get; }            
            //public string Name { set; get; }
            //public string Alias { set; get; }
            //public int PostCatagoryID { set; get; }
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.PostCatagoryID = postViewModel.PostCatagoryID;
            post.CreatedBy = postViewModel.CreatedBy;
            post.CreatedDate = postViewModel.CreatedDate;
            post.Alias = postViewModel.Alias;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.UpdateBy = postViewModel.UpdateBy;
            post.UpdateDate = postViewModel.UpdateDate;

        }

        public static void UpdatePostCatagory(this PostCatagory postCatagory, PostCatagoryViewModel postCatagoryViewModel)
        {
            //public int ID { set; get; }
            //public string Name { set; get; }
            //public string Alias { set; get; }
            //public int ParentID { set; get; }
            //public string Description { set; get; }
            //public int DisplayOrder { set; get; }
            //public string Image { set; get; }
            ////public XElement MoreImage { set; get; }            
            postCatagory.ID = postCatagoryViewModel.ID;
            postCatagory.Name = postCatagoryViewModel.Name;
            postCatagory.Alias = postCatagoryViewModel.Alias;
            postCatagory.ParentID = postCatagoryViewModel.ParentID;
            postCatagory.Description = postCatagoryViewModel.Description;
            postCatagory.DisplayOrder = postCatagoryViewModel.DisplayOrder;
            postCatagory.Image = postCatagoryViewModel.Image;
            //postCatagory.MoreImage = postCatagoryViewModel.MoreImage;
            postCatagory.CreatedBy = postCatagoryViewModel.CreatedBy;
            postCatagory.CreatedDate = postCatagoryViewModel.CreatedDate;
            postCatagory.Alias = postCatagoryViewModel.Alias;
            postCatagory.MetaDescription = postCatagoryViewModel.MetaDescription;
            postCatagory.MetaKeyword = postCatagoryViewModel.MetaKeyword;
            postCatagory.UpdateBy = postCatagoryViewModel.UpdateBy;
            postCatagory.UpdateDate = postCatagoryViewModel.UpdateDate;

        }
    }
}