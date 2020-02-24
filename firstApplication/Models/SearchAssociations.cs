using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class SearchAssociations
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string SearchTerm { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int Priority { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserIdCreated { get; set; }
        public int UserIdModified { get; set; }
    }
}
