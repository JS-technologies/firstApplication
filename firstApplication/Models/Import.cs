using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class Import
    {
        public string Id { get; set; }
        public string SiteId { get; set; }
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
        public string CreatedById { get; set; }
        public string LastModifiedById { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string IsDeleted { get; set; }
        public string IsActive { get; set; }
    }
}
