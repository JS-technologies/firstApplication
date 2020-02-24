using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class RankingManagerExplode
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? CollectionId { get; set; }
        public int? RankingManagerId { get; set; }
        public int? Level { get; set; }
        public int? Rankset { get; set; }
        public string Segment { get; set; }
        public int? ProfileId { get; set; }
        public string CampaignDetails { get; set; }
    }
}
