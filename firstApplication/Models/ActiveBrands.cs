using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ActiveBrands
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string Brand { get; set; }
        public string Gnvbrand { get; set; }
        public int CollectionId { get; set; }
        public int NoOfProducts { get; set; }
        public DateTime LastPublishedDate { get; set; }
        public int IsNew { get; set; }
        public int? ParentId { get; set; }
        public int? CollectionLevel { get; set; }
    }
}
