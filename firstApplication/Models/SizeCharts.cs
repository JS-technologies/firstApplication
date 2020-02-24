using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class SizeCharts
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string SizeChart { get; set; }
        public int CollectionId { get; set; }
        public int? CollectionLevel { get; set; }
    }
}
