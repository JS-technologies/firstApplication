using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class SiteTags
    {
        public int TagId { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string Text { get; set; }
    }
}
