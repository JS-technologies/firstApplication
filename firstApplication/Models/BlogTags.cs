using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class BlogTags
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string TagName { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string Url { get; set; }
        public string H1 { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTags { get; set; }
        public string HeaderTags { get; set; }
        public string Seotext { get; set; }
        public int CreatedById { get; set; }
        public int LastModifiedById { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public bool ShowInHp { get; set; }
    }
}
