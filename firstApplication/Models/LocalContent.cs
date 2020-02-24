using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class LocalContent
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string PageName { get; set; }
        public string LabelName { get; set; }
        public string LabelFriendlyName { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Interface { get; set; }
        public int? PageNameHash { get; set; }
        public int? LabelNameHash { get; set; }

        public virtual LocalContentPages PageNameNavigation { get; set; }
    }
}
