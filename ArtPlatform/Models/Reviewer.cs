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
        public long CertificateNumber { get; set; }

        [Required]
        public DateTime CertificateIssueDate { get; set; }

        public List<Post> RatedPosts { get; set; }

        public Reviewer()
        {

        }

        public Reviewer(int idUser, string nickname, string firstName, string lastName, string bioDesc, string email, string password, DateTime regDate, long certificateNumber) : base(idUser, nickname, firstName, lastName, bioDesc, email, password, regDate)
        {
            CertificateNumber = certificateNumber;
            RatedPosts = new List<Post>();
        }
    }
}
