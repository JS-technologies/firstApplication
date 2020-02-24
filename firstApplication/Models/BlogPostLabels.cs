using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class BlogPostLabels
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string Label { get; set; }
        public bool IsDeleted { get; set; }
    }
}
