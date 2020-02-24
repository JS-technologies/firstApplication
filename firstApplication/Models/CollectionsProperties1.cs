using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class CollectionsProperties1
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public int SiteId { get; set; }
        public string Activated { get; set; }
        public int DisplayPosition { get; set; }
        public string HasLandingPage { get; set; }
        public string DynamicLandingPage { get; set; }
        public string HasNavigationBar { get; set; }
        public string ShowInMenu { get; set; }
        public string HideSearch { get; set; }
        public string CollectionType { get; set; }
        public string CollectionStatus { get; set; }
        public string CollectionLayout { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte[] CollectionsPropertiesTimestamp { get; set; }
        public string StyleAttribute { get; set; }
        public decimal MinDiscount { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string DocumentId { get; set; }
        public int AutomaticTagId { get; set; }
        public decimal MaxDiscount { get; set; }
        public string Mobile { get; set; }
    }
}
