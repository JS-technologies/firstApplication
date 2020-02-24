using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class GlobalParametersMessages
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string GroupType { get; set; }
        public string Code { get; set; }
        public string Variant { get; set; }
        public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }
        public int Rank { get; set; }
    }
}
