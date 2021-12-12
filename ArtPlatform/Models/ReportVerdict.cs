using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class ReportVerdict
    {
        [Required]
        public User User { get; set; }
        [Required]
        public Report Report { get; set; }

        public ReportVerdict(User user, Report report)
        {
            User = user;
            Report = report;
        }
    }
}
