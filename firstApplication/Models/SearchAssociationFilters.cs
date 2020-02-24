using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class SearchAssociationFilters
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public int SearchTermId { get; set; }
        public string FilterLabel { get; set; }
        public string FilterUrl { get; set; }
        public int SortRank { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserIdCreated { get; set; }
        public int UserIdModified { get; set; }
    }
}
