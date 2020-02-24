﻿using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class StaticPages
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public bool ShowHeader { get; set; }
        public bool ShowMainOptions { get; set; }
        public bool ShowFooter { get; set; }
        public string MetaKeywords { get; set; }
        public string MasterPage { get; set; }
        public string Breadcrumb { get; set; }
        public string Footer { get; set; }
        public string PageType { get; set; }
        public string MetaTags { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string Seotext { get; set; }
        public string H1 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string RedirectUrl { get; set; }
        public DateTime? PublishStartDate { get; set; }
        public DateTime? PublishEndDate { get; set; }
        public int Status { get; set; }
    }
}
