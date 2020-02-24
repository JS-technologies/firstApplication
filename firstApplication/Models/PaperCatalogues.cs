using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class PaperCatalogues
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string CatalogueId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
