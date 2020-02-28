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

        public BlogPostsV2 AddBlog(BlogPostsV2 blogToAdd)
        {
            DateTime dateCreated = DateTime.Now;
            DateTime dateModified = DateTime.Now;
            blogToAdd.DateCreated = dateCreated;
            blogToAdd.DateModified = dateModified;
            DateTime startDate = DateTime.Now;
            blogToAdd.PublishStartDate = startDate;
            blogToAdd.PublishEndDate = null;
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
            
            blogToAdd.CreatedById = 15;
            blogToAdd.LastModifiedById = 15;
            blogToAdd.IsDeleted = false;
           
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

        public BlogPostsV2 getByBlogById(int? id)
        {
            var blogPostToEdit = (from b in _context.BlogPostsV2
                                  where b.Id == id
                                  select b).FirstOrDefault();
            return blogPostToEdit;
        }

        public BlogPostsV2 editBlog(BlogPostsV2 blogToEdit)
        {

            blogToEdit.CreatedById = 15;
            blogToEdit.LastModifiedById = 15;
            DateTime dateCreated = DateTime.Now;
            DateTime dateModified = DateTime.Now;
            blogToEdit.DateCreated = dateCreated;
            blogToEdit.DateModified = dateModified;
            DateTime startDate = DateTime.Now;
            blogToEdit.PublishStartDate = startDate;

            _context.BlogPostsV2.Update(blogToEdit);
            _context.SaveChangesAsync();
            return blogToEdit;
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