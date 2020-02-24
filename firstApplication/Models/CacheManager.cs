using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class CacheManager
    {
        public int Id { get; set; }
        public string CacheType { get; set; }
        public string CacheKey { get; set; }
        public int CacheKeyHash { get; set; }
        public DateTime DateCreated { get; set; }
        public int Duration { get; set; }
        public DateTime DateExpires { get; set; }
        public int? Hits { get; set; }
        public byte[] CacheDetails { get; set; }
    }
}
