using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class Tags
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Duration { get; set; }
        public int Priority { get; set; }
        public string PositionProductList { get; set; }
        public string PositionProductPage { get; set; }
        public int TagType { get; set; }
        public bool IsAutomatic { get; set; }
        public int ParentTagId { get; set; }
    }
}
