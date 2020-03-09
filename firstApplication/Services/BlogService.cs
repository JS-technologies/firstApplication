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

        public List<BlogPostsV2> LoadBlogs()
        {
            var blogs = (from b in _context.BlogPostsV2
                         select b).ToList();
            return blogs;
        }

        public BlogPostsV2 LoadDetails(int id)
        {
            var blogDetails = (from b in _context.BlogPostsV2
                               where b.Id == id
                               select b).FirstOrDefault();
            return blogDetails;
        }

        public bool AddBlog(BlogPostsV2 blogToAdd, out int blogId)
        {
            DateTime dateCreated = DateTime.Now;
            DateTime dateModified = DateTime.Now;
            blogToAdd.DateCreated = dateCreated;
            blogToAdd.DateModified = dateModified;
            DateTime startDate = DateTime.Now;
            blogToAdd.PublishStartDate = startDate;
            blogToAdd.PublishEndDate = null;
            blogToAdd.CreatedById = 15;
            blogToAdd.LastModifiedById = 15;
            blogToAdd.IsDeleted = false;

            try
            {
                _context.Add(blogToAdd);
                _context.SaveChanges();
                blogId = blogToAdd.Id;
                return true;
            }
            catch (Exception) {
                blogId = -1;
                return false;
            }
            //return blogToAdd;
        }
        public bool editBlog(BlogPostsV2 blogToEdit)
        {
            var blogToUpdate = _context.BlogPostsV2.FirstOrDefault(x => x.Id == blogToEdit.Id);

            blogToUpdate.Label = blogToEdit.Label;
            blogToUpdate.SiteId = blogToEdit.SiteId;
            blogToUpdate.Status = blogToEdit.Status;
            blogToUpdate.LangCode = blogToEdit.LangCode;
            blogToUpdate.Url = blogToEdit.Url;
            blogToUpdate.Title = blogToEdit.Title;
            blogToUpdate.HomePageImageUrl = blogToEdit.HomePageImageUrl;
            blogToUpdate.HomePageImageAlt = blogToEdit.HomePageImageAlt;
            blogToUpdate.CoverImageUrl = blogToEdit.CoverImageUrl;
            blogToUpdate.CoverImageAlt = blogToEdit.CoverImageAlt;
            blogToUpdate.Seoscore = blogToEdit.Seoscore;
            blogToUpdate.MetaDescription = blogToEdit.MetaDescription;
            blogToUpdate.MetaTags = blogToEdit.MetaTags;
            blogToUpdate.HeaderTags = blogToEdit.HeaderTags;
            blogToUpdate.Categories = blogToEdit.Categories;
            blogToUpdate.ShowInPdpcategories = blogToEdit.ShowInPdpcategories;
            blogToUpdate.AssociatedProducts = blogToEdit.AssociatedProducts;
            blogToUpdate.ShowInPdpproducts = blogToEdit.ShowInPdpproducts;
            blogToUpdate.Content = blogToEdit.Content;
            blogToUpdate.Tags = blogToEdit.Tags;
            blogToUpdate.RedirectUrl = blogToEdit.RedirectUrl;
            blogToUpdate.RedirectionType = blogToEdit.RedirectionType;
            blogToUpdate.PublishEndDate = blogToEdit.PublishEndDate;
            blogToUpdate.IsDeleted = blogToEdit.IsDeleted;


            blogToEdit.CreatedById = 15;
            blogToEdit.LastModifiedById = 15;
            DateTime dateModified = DateTime.Now;
            blogToEdit.DateModified = dateModified;
            DateTime startDate = DateTime.Now;
            blogToEdit.PublishStartDate = startDate;

            try
            {
                _context.Update(blogToUpdate);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //return blogToEdit;
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

        public BlogPostsV2 getByBlogById(int? id)
        {
            var blogPostToEdit = (from b in _context.BlogPostsV2
                                  where b.Id == id
                                  select b).FirstOrDefault();
            return blogPostToEdit;
        }

        
        public bool checkIfBlogExists(int id)
        {
            bool decider;
            var blogPostToEdit = (from b in _context.BlogPostsV2
                                  where b.Id == id
                                  select b).FirstOrDefault();
            if(blogPostToEdit != null)
            {
                decider = true;
            }
            else
            {
                decider = false;
            }
            return decider;
        }

    }
}