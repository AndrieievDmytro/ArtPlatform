using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models {

    public class Review {

        [Required]
        public Reviewer Reviewer { get; set; }
        [Required]
        public Post Post { get; set; }

        public Review(Reviewer reviewer, Post post) {
            Reviewer = reviewer;
            Post = post;
        }

    }

}
