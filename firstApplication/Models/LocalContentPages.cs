using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class LocalContentPages
    {
        public LocalContentPages()
        {
            LocalContent = new HashSet<LocalContent>();
        }

        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageFriendlyName { get; set; }
        public string PageDescription { get; set; }

        public virtual ICollection<LocalContent> LocalContent { get; set; }
    }
}
