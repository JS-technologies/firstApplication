using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class GlobalParametersGroupTypes
    {
        public string GroupType { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public bool? IsTranslatable { get; set; }
    }
}
