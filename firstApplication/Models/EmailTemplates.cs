using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class EmailTemplates
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Body { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string EmailTemplateType { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Description { get; set; }
        public string EmailType { get; set; }
        public string Subject { get; set; }
        public string Bcc { get; set; }
    }
}
