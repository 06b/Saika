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
        public string AttackSteps { get; set; }
        public string Notes { get; set; }
        public string AffectedPaths { get; set; }
    }
}