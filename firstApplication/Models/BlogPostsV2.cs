using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace firstApplication.Models
{
    public enum BlogPostStatus
    {
        [Display(Name = "Live")]
        Live = 1,
        [Display(Name = "Archived")]
        Archived = 2,
        [Display(Name = "Scheduled")]
        Scheduled = 3,
        [Display(Name = "Draft")]
        Draft = 4
    }
    public partial class BlogPostsV2
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public bool ShowInHp { get; set; }
        public string Label { get; set; }
        public string MetaTags { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string RedirectUrl { get; set; }
        public DateTime? PublishStartDate { get; set; }
        public DateTime? PublishEndDate { get; set; }
        public BlogPostStatus Status { get; set; }
        public int RedirectionType { get; set; }
        public int Seoscore { get; set; }
        public string CoverImageUrl { get; set; }
        public string Tags { get; set; }
        public string HeaderTags { get; set; }
        public string Categories { get; set; }
        public int CreatedById { get; set; }
        public int LastModifiedById { get; set; }
        public bool IsDeleted { get; set; }
        public string HomePageImageUrl { get; set; }
        public string CoverImageAlt { get; set; }
        public string HomePageImageAlt { get; set; }
        public string AssociatedProducts { get; set; }
        public bool ShowInPdpcategories { get; set; }
        public bool ShowInPdpproducts { get; set; }
    }
}
