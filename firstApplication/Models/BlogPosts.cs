using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class BlogPosts
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string PostContent { get; set; }
        public int AuthorId { get; set; }
        public string MetaData { get; set; }
        public string Url { get; set; }
        public DateTime DateImported { get; set; }
    }
}
