using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ProductVendors
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string VendorId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LogoUrl { get; set; }
        public string ZanoxCid { get; set; }
        public bool? HideContactButton { get; set; }
    }
}
