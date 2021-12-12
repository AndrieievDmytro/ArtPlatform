using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Report
    {
        [Required]
        [Key]
        public int IdReport { get; set; }
        [Required]
        public string ReportType { get; set; }
        [Required]
        public int IdReportedUser { get; set; }
        [Required]
        public int IdReportingUser { get; set; }
        public string Comment { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Moderator Moderator { get; set; }

        public Report(int idReport, string reportType, int idReportedUser, int idReportingUser, string comment, User user, Moderator moderator)
        {
            IdReport = idReport;
            ReportType = reportType;
            IdReportedUser = idReportedUser;
            IdReportingUser = idReportingUser;
            Comment = comment;
            User = user;
            Moderator = moderator;
        }

        public List<Report> GetAllReports()
        {
            return null;
        }

        public ReportVerdict ReviewReport()
        {
            return null;
        }

    }
}
