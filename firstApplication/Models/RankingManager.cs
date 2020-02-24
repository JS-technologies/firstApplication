using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class RankingManager
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string RankType { get; set; }
        public string TypeId { get; set; }
        public int RankSet { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool CanUseToRank { get; set; }
    }
}
