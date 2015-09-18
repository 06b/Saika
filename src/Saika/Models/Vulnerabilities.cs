using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saika.Models
{
    public class Vulnerabilities
    {
        public Guid VulnerabilityId { get; set; }
        public string VulnerabilityName { get; set; }
        public string Notes { get; set; }
        public string Attack { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string VulnerabilityReferences { get; set; }
    }
}