using firstApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstApplication.Services
{
    public class BlogService
    {
        private readonly TheseusRDContext _context;
        public BlogService(TheseusRDContext pContext)
        {
            _context = pContext;
        }

        public List<BlogPostsV2> LoadBlogs(int siteId = 1)
        {
            var blogs = (from b in _context.BlogPostsV2
                         where b.SiteId == siteId && b.IsDeleted == false
                         select b).ToList();
            return blogs;
        }

        public BlogPostsV2 LoadDetails(int id, int siteId = 1)
        {
            var blogDetails = (from b in _context.BlogPostsV2
                               where b.SiteId == siteId && b.Id == id
                               select b).FirstOrDefault();
            return blogDetails;
        }

        public BlogPostsV2 AddBlog(int id, int SiteId, string LangCode, string Title, string MetaDescription, string Content,
            string Url, bool ShowInHp, string label, string MetaTags, string RedirectUrl, DateTime? PublishEndDate,
            int Status, int redirectionType, int SEOScore, string CoverImageUrl, string Tags, string HeaderTags, string Categories,
            string HomePageImageUrl, string CoverImageAlt, string HomePageImageAlt,
            string AssociatedProducts, bool ShowInPDPCategories, bool ShowInPDPProducts)
        {

            var blogToAdd = new BlogPostsV2();

            blogToAdd.Id = id;
            blogToAdd.SiteId = SiteId;
            blogToAdd.LangCode = LangCode;
            blogToAdd.Title = Title;
            blogToAdd.MetaDescription = MetaDescription;
            blogToAdd.Content = Content;
            blogToAdd.Url = Url;
            blogToAdd.ShowInHp = ShowInHp;
            blogToAdd.Label = label;
            blogToAdd.MetaTags = MetaTags;
            DateTime dateCreated = DateTime.Now;
            DateTime dateModified = DateTime.Now;
            blogToAdd.DateCreated = dateCreated;
            blogToAdd.DateModified = dateModified;
            blogToAdd.RedirectUrl = RedirectUrl;
            DateTime startDate = DateTime.Now;
            blogToAdd.PublishStartDate = startDate;
            blogToAdd.PublishEndDate = null;
            blogToAdd.Status = (BlogPostStatus)Status;
            //BlogPostStatus stat = BlogPostStatus.Live; 
            //switch(Status)
            //{
            //    case 1:
            //        stat = BlogPostStatus.Live;
            //    break;

            //    case 2:
            //        stat = BlogPostStatus.Archived;
            //        break;

            //    case 3:
            //        stat = BlogPostStatus.Scheduled;
            //        break;

            //    case 4:
            //        stat = BlogPostStatus.Draft;
            //        break;
            //}

            //blogToAdd.Status = stat;
            blogToAdd.RedirectionType = redirectionType;
            blogToAdd.Seoscore = SEOScore;
            blogToAdd.CoverImageUrl = CoverImageUrl;
            blogToAdd.Tags = Tags;
            blogToAdd.HeaderTags = HeaderTags;
            blogToAdd.Categories = Categories;
            blogToAdd.CreatedById = 15;
            blogToAdd.LastModifiedById = 15;
            blogToAdd.IsDeleted = false;
            blogToAdd.HomePageImageUrl = HomePageImageUrl;
            blogToAdd.CoverImageAlt = CoverImageAlt;
            blogToAdd.HomePageImageAlt = HomePageImageAlt;
            blogToAdd.AssociatedProducts = AssociatedProducts;
            blogToAdd.ShowInPdpcategories = ShowInPDPCategories;
            blogToAdd.ShowInPdpproducts = ShowInPDPProducts;
            _context.Add(blogToAdd);
            _context.SaveChangesAsync();
            return blogToAdd;
        }

        public BlogPostsV2 deleteBlog(int id)
        {
            var blogToDelete = (from b in _context.BlogPostsV2
                                where b.Id == id
                                select b).FirstOrDefault();

            _context.BlogPostsV2.Remove(blogToDelete);
            _context.SaveChangesAsync();
            return blogToDelete;
        }
    }
}