using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class Regions
    {
        public int Id { get; set; }
        public string Pcode { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string Division { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
    }
}
