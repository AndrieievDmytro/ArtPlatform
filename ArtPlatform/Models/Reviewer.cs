using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Reviewer : User
    {
        [Required]
        public int CertificateNumber { get; set; }

        [Required]
        public DateTime CertificateIssueDate { get; set; }

        public List<Post> RatedPosts { get; set; }
    }
}
