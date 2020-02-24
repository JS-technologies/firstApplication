using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class Collections1
    {
        public int Id { get; set; }
        public int NavigationId { get; set; }
        public string CollectionTitle { get; set; }
        public int ParentId { get; set; }
        public int CollectionLevel { get; set; }
        public int CollectionCount { get; set; }
        public string Activated { get; set; }
        public byte[] CollectionsTimestamp { get; set; }
        public string MainCollectionType { get; set; }
    }
}
