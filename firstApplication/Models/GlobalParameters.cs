using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class GlobalParameters
    {
        public int Id { get; set; }
        public string GroupType { get; set; }
        public string Code { get; set; }
        public string Variant { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
    }
}
