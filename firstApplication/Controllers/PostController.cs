using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;
using PagedList.Mvc;
using PagedList;
using firstApplication.Services;

namespace firstApplication.Controllers
{
    public class PostController : Controller
    {
        private BlogService bService;


        public PostController(TheseusRDContext context)
        {
            bService = new BlogService(context);
        }

        // GET: Post
        public async Task<IActionResult> Index()
        {
            return View(bService.LoadBlogs());
        }
        
        // GET: Post/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(bService.LoadDetails(id));
        }
        
        // GET: Post/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SiteId,LangCode,Title,MetaDescription,Content,Url,ShowInHp,Label,MetaTags,DateCreated,DateModified,RedirectUrl,PublishStartDate,PublishEndDate,Status,RedirectionType,Seoscore,CoverImageUrl,Tags,HeaderTags,Categories,CreatedById,LastModifiedById,IsDeleted,HomePageImageUrl,CoverImageAlt,HomePageImageAlt,AssociatedProducts,ShowInPdpcategories,ShowInPdpproducts")] BlogPostsV2 blogPostsV2)
        {
            int number = 0;
            if (ModelState.IsValid)
            {
                switch (blogPostsV2.Status)
                {
                    case BlogPostStatus.Live:
                        number = 1;
                        break;

                    case BlogPostStatus.Archived:
                        number = 2;
                        break;

                    case BlogPostStatus.Scheduled:
                        number = 3;
                        break;

                    case BlogPostStatus.Draft:
                        number = 4;
                        break;
                }
                bService.AddBlog(blogPostsV2.Id, blogPostsV2.SiteId, blogPostsV2.LangCode, blogPostsV2.Title, blogPostsV2.MetaDescription, blogPostsV2.Content, blogPostsV2.Url, blogPostsV2.ShowInHp, blogPostsV2.Label, blogPostsV2.MetaTags, blogPostsV2.RedirectUrl, blogPostsV2.PublishEndDate, number, blogPostsV2.RedirectionType, blogPostsV2.Seoscore, blogPostsV2.CoverImageUrl, blogPostsV2.Tags, blogPostsV2.HeaderTags, blogPostsV2.Categories, blogPostsV2.HomePageImageUrl, blogPostsV2.CoverImageAlt, blogPostsV2.HomePageImageAlt, blogPostsV2.AssociatedProducts, blogPostsV2.ShowInPdpcategories, blogPostsV2.ShowInPdpproducts);
                return RedirectToAction("Index");
            }
            return View();
        }

        /*
        // GET: Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostsV2 = await _context.BlogPostsV2.FindAsync(id);
            if (blogPostsV2 == null)
            {
                return NotFound();
            }
            return View(blogPostsV2);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SiteId,LangCode,Title,MetaDescription,Content,Url,ShowInHp,Label,MetaTags,DateCreated,DateModified,RedirectUrl,PublishStartDate,PublishEndDate,Status,RedirectionType,Seoscore,CoverImageUrl,Tags,HeaderTags,Categories,CreatedById,LastModifiedById,IsDeleted,HomePageImageUrl,CoverImageAlt,HomePageImageAlt,AssociatedProducts,ShowInPdpcategories,ShowInPdpproducts")] BlogPostsV2 blogPostsV2)
        {
            if (id != blogPostsV2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPostsV2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostsV2Exists(blogPostsV2.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostsV2);
        }*/

        // GET: Post/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostsV2 = bService.deleteBlog(id);
            if (blogPostsV2 == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPostsV2 = bService.deleteBlog(id);
            return RedirectToAction("Index");
        }

        /*private bool BlogPostsV2Exists(int id)
        {
            return _context.BlogPostsV2.Any(e => e.Id == id);
        }*/
    }
}
