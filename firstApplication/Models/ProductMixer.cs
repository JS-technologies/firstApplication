using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ProductMixer
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeType { get; set; }
        public int Rank { get; set; }
        public int CollectionId { get; set; }
        public string Brand { get; set; }
        public int ProductId { get; set; }
    }
}
