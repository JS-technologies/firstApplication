using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ActiveProductAttributes
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string ProductId { get; set; }
        public string DocumentId { get; set; }
        public string ProductDimension1 { get; set; }
        public string ProductDimension2 { get; set; }
        public string PresCode { get; set; }
        public string AttributeType { get; set; }
        public int AttributeRank { get; set; }
        public int AttributeRank2 { get; set; }
        public bool? IsVisible { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public int Value3Hash { get; set; }
        public int Value3UrlHash { get; set; }
    }
}
