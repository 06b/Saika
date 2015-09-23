using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saika.Models
{
    public class Issues
    {
        public Guid IssueId { get; set; }
        public string IssueTitle { get; set; }
        public string VulnerabilityTestType { get; set; }  //Manual - Automated Scan - Online Scan/Service
        public string VulnerabilityTestTool { get; set; } //Name of tool
        public string VulnerabilityTestToolUrl { get; set; } //Url of tools / sites used.
        public string AttackSteps { get; set; }
        public string AffectedPaths { get; set; }
        public string Notes { get; set; }
    }
}