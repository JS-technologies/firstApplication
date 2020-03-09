using firstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApplication.Services
{
    public class UserService
    {
        private readonly TheseusContext _theseusContext;
        private readonly TheseusRDContext _context;
        public UserService(TheseusContext theseusContext, TheseusRDContext context)
        {
            _theseusContext = theseusContext;
            _context = context;
        }

        public List<User> LoadUsers()
        {
            var Users = (from u in _theseusContext.Users
                         select u).ToList();
            return Users;
        }
        public List<BlogPostsV2> getBlogs(int id)
        {
            var Blogs = (from b in _context.BlogPostsV2
                         where b.CreatedById == id
                         select b).ToList();
            return Blogs;
        }
    }
}
