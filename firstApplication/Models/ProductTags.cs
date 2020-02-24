using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ProductTags
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string ProductId { get; set; }
        public string DocumentId { get; set; }
        public int TagId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
