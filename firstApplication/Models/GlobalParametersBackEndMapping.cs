using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class GlobalParametersBackEndMapping
    {
        public int Id { get; set; }
        public int Siteid { get; set; }
        public string BackEndName { get; set; }
        public string GroupType { get; set; }
        public string BackendCode { get; set; }
        public string BackendVariant { get; set; }
        public string TheseusCode { get; set; }
        public string TheseusVariant { get; set; }
    }
}
