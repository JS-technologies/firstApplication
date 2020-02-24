using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ActiveNavigationStatistics1
    {
        public int CollectionLevel { get; set; }
        public int CollectionId { get; set; }
        public int DisplayPosition { get; set; }
        public int ParentId { get; set; }
        public int? NoOfProducts { get; set; }
        public int TopLevelId { get; set; }
        public int NavigationId { get; set; }
        public int SiteId { get; set; }
    }
}
