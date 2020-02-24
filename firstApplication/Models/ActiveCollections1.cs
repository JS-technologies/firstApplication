using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ActiveCollections1
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int NavigationId { get; set; }
        public string ProductId { get; set; }
        public string DocumentId { get; set; }
        public int Levels { get; set; }
        public int Level1 { get; set; }
        public int Level2 { get; set; }
        public int Level3 { get; set; }
        public int Level4 { get; set; }
        public int Level5 { get; set; }
        public int BottomLevel { get; set; }
    }
}
