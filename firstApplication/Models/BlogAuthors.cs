using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class BlogAuthors
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
