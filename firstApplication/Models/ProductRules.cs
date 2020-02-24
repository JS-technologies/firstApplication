using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ProductRules
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string RuleType { get; set; }
        public int? CategoryId { get; set; }
        public string Family { get; set; }
        public string SubFamily { get; set; }
        public string Size { get; set; }
        public string LangCode { get; set; }
        public string MiniSize { get; set; }
        public string Brand { get; set; }
        public string Pdptitle { get; set; }
        public string ProductId { get; set; }
        public string PdpseoText { get; set; }
        public string DocumentId { get; set; }
    }
}
